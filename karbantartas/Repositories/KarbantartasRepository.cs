using karbantartas.Models;

namespace karbantartas.Repositories
{
    public interface KarbantartasRepository
    {
        Task<IEnumerable<object>> GetKarbantartok();

        Task<IEnumerable<object>> GetFeladatok(long f_id);

    }
}
