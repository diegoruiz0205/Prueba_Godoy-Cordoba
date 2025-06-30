namespace Prueba_Api.Repositories
{
    public interface IGifRepository
    {
        Task<string> GetGifUrlAsync(string query);
    }
}
