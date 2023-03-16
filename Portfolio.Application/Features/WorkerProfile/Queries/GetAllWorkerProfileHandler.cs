using AutoMapper;
using MediatR;
using Portfolio.Application.Features.WorkerProfile;
using Portfolio.Core.DTO.WorkerProfile;
using Portfolio.Core.Interfaces.Management;
using Portfolio.Core.Interfaces.Services;

namespace Portfolio.Application.Features.Country
{
    public class GetAllWorkerProfileHandler : IRequestHandler<GetAllWorkerProfileQuery, IEnumerable<WorkerProfileDTO>>
    {

        private readonly IMapper _mapper;
        private readonly IUriService _uriService;
        private readonly IModelHelper _modelHelper;

        private readonly IWorkerProfileService _workerProfile;

        public GetAllWorkerProfileHandler(IWorkerProfileService workerProfile, IMapper mapper, IModelHelper modelHelper, IUriService uriService) =>
            (_mapper, _uriService, _modelHelper, _workerProfile) = (mapper, uriService, modelHelper, workerProfile);


        public async Task<IEnumerable<WorkerProfileDTO>> Handle(GetAllWorkerProfileQuery request, CancellationToken cancellationToken) =>
            await _workerProfile.GetWorkerProfiles(cancellationToken);

    }
}
