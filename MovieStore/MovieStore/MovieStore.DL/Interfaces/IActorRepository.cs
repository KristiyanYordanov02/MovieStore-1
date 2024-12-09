using MovieStore.Models.DTO;

namespace MovieStore.DL.Interfaces
{
    public interface IActorRepository
    {
        IEnumerable<Actor> GetActorsByIds(IEnumerable<int> actors);
        Actor? GetById(int id);
    }
}