using AutoMapper;
using Portfolio.Application.Features.Country;
using Portfolio.Core.Custom;
using Portfolio.Core.DTO;
using Portfolio.Core.DTO.Resume;
using Portfolio.Core.DTO.WorkerProfile;
using Portfolio.Core.Entities;

namespace Portfolio.Application.Mappings
{
    public class AutoMapperProfile : Profile
    {

        public AutoMapperProfile()
        {
            /* Mapping PagedList objects. */
            CreateMap(typeof(PagedList<>), typeof(MetaData<>)).ConvertUsing(typeof(ConverterPaging<,>));

            /* Mapping queries and parameters. */
            CreateMap<Country, CountryDTO>().ReverseMap();
            CreateMap<GetAllCountryQuery, GetAllCountryParameter>().ReverseMap();
            
            CreateMap<WorkerProfile, WorkerProfileDTO>().ReverseMap();
            CreateMap<WorkerProfile, CreateWorkerProfileDTO>().ReverseMap();
            CreateMap<WorkerProfileDTO, CreateWorkerProfileDTO>().ReverseMap();
            CreateMap<WorkerProfile, UpdateWorkerProfileDTO>().ReverseMap();
            CreateMap<WorkerProfileDTO, UpdateWorkerProfileDTO>().ReverseMap();
            CreateMap<WorkerProfile, DeleteWorkerProfileDTO>().ReverseMap();
            CreateMap<WorkerProfileDTO, DeleteWorkerProfileDTO>().ReverseMap();

            CreateMap<Resume, ResumeDTO>().ReverseMap();
            CreateMap<Resume, CreateResumeDTO>().ReverseMap();
            CreateMap<ResumeDTO, CreateResumeDTO>().ReverseMap();
            CreateMap<Resume, UpdateResumeDTO>().ReverseMap();
            CreateMap<ResumeDTO, UpdateResumeDTO>().ReverseMap();
            CreateMap<Resume, DeleteResumeDTO>().ReverseMap();
            CreateMap<ResumeDTO, DeleteResumeDTO>().ReverseMap();

            CreateMap<Entity, EntityDTO>().ReverseMap();
            CreateMap<Entity, CreateEntityDTO>().ReverseMap();
            CreateMap<EntityDTO, CreateEntityDTO>().ReverseMap();
            CreateMap<Entity, UpdateEntityDTO>().ReverseMap();
            CreateMap<EntityDTO, UpdateEntityDTO>().ReverseMap();
            CreateMap<Entity, DeleteEntityDTO>().ReverseMap();
            CreateMap<EntityDTO, DeleteEntityDTO>().ReverseMap();
        }
    }
}
