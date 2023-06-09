using AutoMapper;
using Portfolio.Application.Features.Aptitude.Queries;
using Portfolio.Application.Features.Country;
using Portfolio.Core.Custom;
using Portfolio.Core.DTO;
using Portfolio.Core.DTO.Resume;
using Portfolio.Core.DTO.ResumeType;
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

            CreateMap<ResumeType, ResumeTypeDTO>().ReverseMap();
            CreateMap<ResumeType, CreateResumeTypeDTO>().ReverseMap();
            CreateMap<ResumeTypeDTO, CreateResumeTypeDTO>().ReverseMap();
            CreateMap<ResumeType, UpdateResumeTypeDTO>().ReverseMap();
            CreateMap<ResumeTypeDTO, UpdateResumeTypeDTO>().ReverseMap();
            CreateMap<ResumeType, DeleteResumeTypeDTO>().ReverseMap();
            CreateMap<ResumeTypeDTO, DeleteResumeTypeDTO>().ReverseMap();

            CreateMap<Aptitude, AptitudeDTO>().ReverseMap();
            CreateMap<Aptitude, CreateAptitudeDTO>().ReverseMap();
            CreateMap<AptitudeDTO, CreateAptitudeDTO>().ReverseMap();
            CreateMap<UpdateAptitudeDTO, Aptitude>().ReverseMap();
            CreateMap<UpdateAptitudeDTO, AptitudeDTO>().ReverseMap();
            CreateMap<DeleteAptitudeDTO, Aptitude>().ReverseMap();
            CreateMap<DeleteAptitudeDTO, AptitudeDTO>().ReverseMap();

        }
    }
}
