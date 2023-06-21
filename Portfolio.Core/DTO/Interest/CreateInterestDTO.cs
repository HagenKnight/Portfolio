using MediatR;
using Portfolio.Core.DTO.Base;
using Portfolio.Core.Wrappers;

namespace Portfolio.Core.DTO
{
    public class CreateInterestDTO : CommandDTO, IRequest<ApiResponse<CreateInterestDTO>>
    {
        public string Name { get; set; } = string.Empty;
        public int WorkerProfileId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
    }
}
