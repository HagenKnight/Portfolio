using MediatR;
using Portfolio.Core.DTO.Base;
using Portfolio.Core.Wrappers;

namespace Portfolio.Core.DTO
{
    public class UpdateInterestDTO : CommandDTO, IRequest<ApiResponse<UpdateInterestDTO>>
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int WorkerProfileId { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string? LastModifiedBy { get; set; }
    }
}
