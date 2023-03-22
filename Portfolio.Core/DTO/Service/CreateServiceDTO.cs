using MediatR;
using Portfolio.Core.DTO.Base;
using Portfolio.Core.Wrappers;

namespace Portfolio.Core.DTO.Service
{
    public class CreateServiceDTO : CommandDTO, IRequest<ApiResponse<CreateServiceDTO>>
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int WorkerProfileId { get; set; }

        public DateTime CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
    }
}
