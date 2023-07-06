using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Portfolio.Core.Exceptions;
using Portfolio.Core.Exceptions.Api;
using Portfolio.Core.Wrappers;
using Portfolio.Infrastructure.Identity.Authorization;
using System.Linq.Dynamic.Core.Exceptions;

namespace Portfolio.Api.Middleware
{
    public class ErrorHandlerMiddleware : IMiddleware
    {

        public ErrorHandlerMiddleware() { }
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try
            {
                await next(context);
            }
            catch (Exception error)
            {
                var response = context.Response;
                response.ContentType = "application/json";
                var responseModel = new ApiResponse<string>() { Succeeded = false, Message = error?.Message };

                switch (error)
                {
                    case ApiException e:
                        // custom application error
                        response.StatusCode = StatusCodes.Status400BadRequest;
                        break;

                    case ValidateException e:
                        // custom application error
                        response.StatusCode = StatusCodes.Status422UnprocessableEntity;
                        responseModel.Errors = e.ErrorsDictionary;
                        break;

                    case KeyNotFoundException e:
                        // not found error
                        response.StatusCode = StatusCodes.Status404NotFound;
                        break;

                    case EntityNotFoundException e:
                        // not found error
                        response.StatusCode = StatusCodes.Status404NotFound;
                        break;

                    case EntityNotEnabledException e:
                        // not found error
                        response.StatusCode = StatusCodes.Status423Locked;
                        break;

                    case EntityDuplicatedException e:
                        // not found error
                        response.StatusCode = StatusCodes.Status400BadRequest;
                        break;

                    case EntityAlreadyExistException e:
                        // not found error
                        response.StatusCode = StatusCodes.Status400BadRequest;
                        break;

                    case PageRowIndexNotFound e:
                        // not found error
                        response.StatusCode = StatusCodes.Status400BadRequest;
                        break;

                    case PageRowMaximumException e:
                        // not found error
                        response.StatusCode = StatusCodes.Status400BadRequest;
                        break;

                    case PageRowMinimumException e:
                        // not found error
                        response.StatusCode = StatusCodes.Status400BadRequest;
                        break;

                    case BusinessException e:
                        // not found error
                        response.StatusCode = StatusCodes.Status406NotAcceptable;
                        break;

                    case ParseException e:
                        // Bad Request.
                        response.StatusCode = StatusCodes.Status400BadRequest;
                        break;

                    case AuthorizationException e:
                        response.StatusCode = e.Code switch
                        {
                            "401" => StatusCodes.Status401Unauthorized,
                            "403" => StatusCodes.Status403Forbidden,
                            _ => StatusCodes.Status400BadRequest,
                        };
                        break;

                    default:
                        // unhandled error
                        response.StatusCode = StatusCodes.Status500InternalServerError;
                        break;
                }

                await response.WriteAsync(JsonConvert.SerializeObject(responseModel, new JsonSerializerSettings()
                {
                    Culture = System.Globalization.CultureInfo.CurrentCulture,
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                    NullValueHandling = NullValueHandling.Ignore,
                    DateTimeZoneHandling = DateTimeZoneHandling.Local,
                    FloatFormatHandling = FloatFormatHandling.DefaultValue,
                    FloatParseHandling = FloatParseHandling.Decimal,
                    Formatting = Formatting.Indented,
                    ContractResolver = new CamelCasePropertyNamesContractResolver()
                }));
            }
        }
    }
}
