using MediatR;
using Portfolio.Core.DTO.Base;
using Portfolio.Core.Wrappers;

namespace Portfolio.Core.DTO
{
    public class CreateAptitudeDTO : CommandDTO, IRequest<ApiResponse<CreateAptitudeDTO>>
    {
        public string Name { get; set; } = string.Empty;
        public int Value { get; set; }

        public DateTime CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
    }
}
