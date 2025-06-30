using Prueba_Api.Models;

namespace Prueba_Api.Repositories
{
    public interface ICatFactRepository
    {
        Task<CastFact> GetRandomFactAsync();
    }
}
