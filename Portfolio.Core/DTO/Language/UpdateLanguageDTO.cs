using MediatR;
using Portfolio.Core.DTO.Base;
using Portfolio.Core.Wrappers;

namespace Portfolio.Core.DTO
{
    public class UpdateLanguageDTO : CommandDTO, IRequest<ApiResponse<UpdateLanguageDTO>>
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Value { get; set; }
        public int WorkerProfileId { get; set; }

        public DateTime? LastModifiedDate { get; set; }
        public string? LastModifiedBy { get; set; }
    }
}
