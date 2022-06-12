using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIMySQL.Model;

namespace APIMySQL.Data.Repositories
{
    public interface AplicanteInterface
    {
        Task<IEnumerable<Aplicante>> GetAplicantes();
        Task<Aplicante> GetAplicante(int id);
        Task<bool> InsertAplicante(Aplicante aplicante);
    }
}
