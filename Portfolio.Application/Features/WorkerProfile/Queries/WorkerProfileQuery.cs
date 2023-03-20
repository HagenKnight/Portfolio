using MediatR;
using Portfolio.Core.DTO.WorkerProfile;
using Portfolio.Core.Parameters;

namespace Portfolio.Application.Features.WorkerProfile
{

    public class GetAllWorkerProfileParameter : RequestParameter { }

    public class GetAllWorkerProfileQuery : IRequest<IEnumerable<WorkerProfileDTO>> { }

    public class GetWorkerProfileQuery : IRequest<WorkerProfileDTO>
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public GetWorkerProfileQuery(int id) => Id = id;

        public GetWorkerProfileQuery(string email) => Email = email;
    }

}
