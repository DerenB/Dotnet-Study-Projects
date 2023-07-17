using Support_Library.Models;

namespace Support_Library.Data
{
    public interface IPersonDataService
    {
        Task CreatePerson(IPersonModel person);
        Task<List<IPersonModel>> ReadPeople();
    }
}