using Microsoft.EntityFrameworkCore;
using Prueba_Api.Data;
using Prueba_Api.Entities;
using Prueba_Api.Models;
using Prueba_Api.Repositories;


namespace Prueba_Api.Services
{
    public class CatFactService : ICatFactService
    {
        private readonly ICatFactRepository _repository;
        private readonly IGifRepository _gifRepository;
        private readonly ApplicationDbContext _context;

        public CatFactService(ICatFactRepository repository, IGifRepository gifRepository, ApplicationDbContext context)
        {
            _repository = repository;
            _gifRepository = gifRepository;
            _context = context;
        }
        public async Task<CastFact> GetFactWithWordsAsync()
        {
            var fact = await _repository.GetRandomFactAsync();

            var words = fact.Fact
                .Split(new[] { ' ', ',', '.', ';', ':', '-', '_', '!', '?','(' }, StringSplitOptions.RemoveEmptyEntries)
                .Where(w => w.Length >= 4) 
                .Distinct()
                .ToList();

            var random = new Random();
            var selected = words.OrderBy(x => random.Next()).Take(3).ToList();
            string query = string.Join(" ", selected);
            string gifUrl = await _gifRepository.GetGifUrlAsync(query);

            var entity = new CatFactEntity
            {
                Fact = fact.Fact,
                Palabra1 = selected.ElementAtOrDefault(0),
                Palabra2 = selected.ElementAtOrDefault(1),
                Palabra3 = selected.ElementAtOrDefault(2),
                GifUrl = gifUrl,
                FechaBusqueda = DateTime.UtcNow
            };

            _context.CatFacts.Add(entity);
            await _context.SaveChangesAsync();


            return new CastFact
            {
                Fact = fact.Fact,
                Palabras = selected,
                GifUrl = gifUrl,
                FechaBusqueda = DateTime.UtcNow
            };
        }
        //Consulta nuevo gif
        public async Task<CastFact> ReprocessGifAsync(int id)
        {
            var fact = await _context.CatFacts.FindAsync(id);

            if (fact == null)
                return null;

            var Palabras = new List<string> { fact.Palabra1, fact.Palabra2, fact.Palabra3};
            var query = string.Join(" ", Palabras);
            var gifUrl = await _gifRepository.GetGifUrlAsync(query);

            var newEntity = new CatFactEntity
            {
                Fact = fact.Fact,
                Palabra1 = fact.Palabra1,
                Palabra2 = fact.Palabra2,
                Palabra3 = fact.Palabra3,
                GifUrl = gifUrl,
                FechaBusqueda = DateTime.UtcNow
            };

            _context.CatFacts.Add(newEntity);
            await _context.SaveChangesAsync();

            return new CastFact
            {
                Fact = fact.Fact,
                Palabras = Palabras,
                GifUrl = gifUrl,
                FechaBusqueda = DateTime.UtcNow
            };
        }
        //Historial
        public async Task<List<CastFact>> GetHistoryAsync()
        {
             var records = await _context.CatFacts
            .OrderByDescending(f => f.FechaBusqueda)
            .ToListAsync();

            return records.Select(r => new CastFact
            {
                Fact = r.Fact,
                Palabras = new List<string> { r.Palabra1, r.Palabra2, r.Palabra3 },
                GifUrl = r.GifUrl,
                FechaBusqueda = r.FechaBusqueda
            }).ToList();
        }

        
    }
}
