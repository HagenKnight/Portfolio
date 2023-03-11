using MediatR;
using Portfolio.Core.DTO.Base;
using Portfolio.Core.Wrappers;

namespace Portfolio.Core.DTO
{
    public class DeleteEntityDTO : CommandDTO, IRequest<ApiResponse<DeleteEntityDTO>>
    {
        public int Id { get; set; }
        public DateTime DeleteDate { get; set; }
        public bool AutoSave { get; set; }
    }
}
