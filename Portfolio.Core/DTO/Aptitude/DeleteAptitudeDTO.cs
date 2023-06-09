using MediatR;
using Portfolio.Core.DTO.Base;
using Portfolio.Core.Wrappers;

namespace Portfolio.Core.DTO
{
    public class DeleteAptitudeDTO : CommandDTO, IRequest<ApiResponse<DeleteAptitudeDTO>>
    {
        public int Id { get; set; }
        public bool AutoSave { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeleteDate { get; set; }
        public string? DeletedBy { get; set; }
    }
}
