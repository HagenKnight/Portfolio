using MediatR;
using Portfolio.Core.DTO.Base;
using Portfolio.Core.DTO.WorkerProfile;
using Portfolio.Core.Wrappers;

namespace Portfolio.Core.DTO.Resume
{
    public class DeleteResumeDTO : CommandDTO, IRequest<ApiResponse<DeleteResumeDTO>>
    {
        public int Id { get; set; }
        public string InstitutionName { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;

        public bool AutoSave { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeleteDate { get; set; }
        public string? DeletedBy { get; set; }
    }
}
