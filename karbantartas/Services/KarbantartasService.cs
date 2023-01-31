using karbantartas.Models;
using karbantartas.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;

namespace karbantartas.Services
{
    public class KarbantartasService : KarbantartasRepository
    {
        private readonly KarbantartoContext _context;

        public KarbantartasService(KarbantartoContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<object>> GetFeladatok(long id)
        {
            var result = from f in _context.Feladatok join a in _context.Anyagszukseglet on f.f_id equals a.f_id_ik.f_id where f.f_id == id select new {f.f_id, a.a_nev }; 
            
            return await result.ToListAsync();

            
        }

        public async Task<IEnumerable<object>> GetKarbantartok()
        {
            var result = from karbantartok in _context.Karbantartok join Karbantartasok in _context.Karbantartasok on karbantartok.karb_id equals Karbantartasok.karb_id_ik.k_id select new { karbantartok.karb_nev };

            return await result.ToListAsync();
        }
    }
}
