using AutoMapper;
using VetApi.DTOS.AnimalDTOS;
using VetApi.Models;

namespace VetApi.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Animal, ReadAnimalDTO>().ReverseMap();
        }
    }
}