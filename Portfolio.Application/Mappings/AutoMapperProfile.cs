using AutoMapper;
using Portfolio.Core.Custom;
using Portfolio.Core.DTO;
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
