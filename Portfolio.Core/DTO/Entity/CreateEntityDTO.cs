using MediatR;
using Portfolio.Core.DTO.Base;
using Portfolio.Core.Wrappers;

namespace Portfolio.Core.DTO
{
    public class CreateEntityDTO : CommandDTO, IRequest<ApiResponse<CreateEntityDTO>>
    {
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
