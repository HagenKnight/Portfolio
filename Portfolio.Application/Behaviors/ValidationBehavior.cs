using FluentValidation;
using MediatR;
using Portfolio.Core.Exceptions;

namespace Portfolio.Application.Behaviors
{
    public class ValidationBehaviour<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
       where TRequest : IRequest<TResponse>
    {
        private readonly IEnumerable<IValidator<TRequest>> _validators;
        public ValidationBehaviour(IEnumerable<IValidator<TRequest>> validators) => _validators = validators;
        public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        {
            if (_validators.Any())
            {
                var context = new ValidationContext<TRequest>(request);
                var validationResults = await Task.WhenAll(_validators.Select(v => v.ValidateAsync(context, cancellationToken)));
                var failures = validationResults.SelectMany(r => r.Errors).Where(f => f != null)
                                                .GroupBy(x => x.PropertyName, x => x.ErrorMessage,
                                                        (propertyName, errorMessages) => new
                                                        {
                                                            Key = propertyName,
                                                            Values = errorMessages.Distinct().ToArray()
                                                        }).ToDictionary(x => x.Key, x => x.Values);

                if (failures.Count > 0)
                    throw new ValidateException(failures);
            }
            return await next();
        }
    }
}
