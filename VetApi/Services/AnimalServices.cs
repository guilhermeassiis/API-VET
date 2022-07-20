using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using VetApi.DTOS.AnimalDTOS;
using VetApi.HATEOAS.Conteiners;
using VetApi.Repository.Interfaces;
using VetApi.Services.Interfaces;

namespace VetApi.Services
{
    public class AnimalServices : IAnimalServices
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _uof;
        private HATEOAS.HATEOAS _hateoas;

        public AnimalServices(IMapper mapper, IUnitOfWork uof)
        {
            _mapper = mapper;
            _uof = uof;

            _hateoas = new HATEOAS.HATEOAS("localhost:5001/api/v1/Assessment");
            _hateoas.AddAction("GET_INFO", "GET");
            _hateoas.AddAction("DELETE_COMMENTS", "DELETE");
        }

        public async Task<IEnumerable<AnimalConteiner>> Get(int skip = 0, int take = 10)
        {
            var animals = await _uof.AnimalsRepository.GetAll(skip, take)
                                .ToListAsync();
            List<AnimalConteiner> conteiners = new List<AnimalConteiner>();
            
            foreach (var animal in animals)
            {
                AnimalConteiner conteiner = new AnimalConteiner();
                var animalDto = _mapper.Map<ReadAnimalDTO>(animal);
                conteiner.Animal = animalDto;
                conteiner.Links = _hateoas.GetActions(animal.Id.ToString());

                conteiners.Add(conteiner);
            }
            return conteiners;

        }
    }
}