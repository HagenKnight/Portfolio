using MediatR;
using Portfolio.Core.DTO.Base;
using Portfolio.Core.Wrappers;

namespace Portfolio.Core.DTO
{
    public class UpdateEntityDTO : CommandDTO, IRequest<ApiResponse<UpdateEntityDTO>>
    {
        public int Id { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
