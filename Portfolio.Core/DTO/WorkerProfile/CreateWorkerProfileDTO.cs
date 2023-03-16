using MediatR;
using Portfolio.Core.DTO.Base;
using Portfolio.Core.Wrappers;

namespace Portfolio.Core.DTO.WorkerProfile
{
    public class CreateWorkerProfileDTO : CommandDTO, IRequest<ApiResponse<CreateWorkerProfileDTO>>
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string AboutMe { get; set; } = string.Empty;
        public DateTime BirthDate { get; set; }
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public int CountryId { get; set; }
        public CountryDTO? Country { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? CreatedBy { get; set; }
    }
}
