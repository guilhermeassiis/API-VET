using System.Collections.Generic;
using System.Threading.Tasks;
using VetApi.HATEOAS.Conteiners;

namespace VetApi.Services.Interfaces
{
    public interface IAnimalServices
    {
        Task<IEnumerable<AnimalConteiner>> Get(int skip = 0, int take = 10);
    }
}