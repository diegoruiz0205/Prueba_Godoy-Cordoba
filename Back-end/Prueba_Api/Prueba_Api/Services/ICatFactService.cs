using Prueba_Api.Models;

namespace Prueba_Api.Services
{
    public interface ICatFactService
    {
        //Task<CastFact> GetFactAsync();
        Task<CastFact> GetFactWithWordsAsync();
        Task<List<CastFact>> GetHistoryAsync();
        Task<CastFact> ReprocessGifAsync(int id);
    }
}
