using MediatR;
using Portfolio.Core.DTO.Base;
using Portfolio.Core.DTO.ResumeType;
using Portfolio.Core.DTO.WorkerProfile;
using Portfolio.Core.Wrappers;

namespace Portfolio.Core.DTO.Resume
{
    public class UpdateResumeDTO : CommandDTO, IRequest<ApiResponse<UpdateResumeDTO>>
    {
        public int Id { get; set; }
        public string InstitutionName { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
        public string Description { get; set; } = string.Empty;
        public WorkerProfileDTO? WorkerProfile { get; set; }
        public int ResumeTypeId { get; set; }
        public ResumeTypeDTO? ResumeType { get; set; }
    }
}
