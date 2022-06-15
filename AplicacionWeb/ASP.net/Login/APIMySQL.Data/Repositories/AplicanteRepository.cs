using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using APIMySQL.Model;
using Dapper;
using MySql.Data.MySqlClient;

namespace APIMySQL.Data.Repositories
{
    public class AplicanteRepository : AplicanteInterface
    {
        private MySQLConfiguration _connectionString;

        public AplicanteRepository(MySQLConfiguration connectionString)
        {
            _connectionString = connectionString;
        }

        protected MySqlConnection dbConnection()
        {
            return new MySqlConnection(_connectionString.ConnectionString);
        }

        public async Task<IEnumerable<Aplicante>> GetAplicantes()
        {
            var db = dbConnection();

            var sql = @"SELECT * FROM Aplicante";

            return await db.QueryAsync<Aplicante>(sql, new { });
        }

        public async Task<Aplicante> GetAplicante(string correo)
        {
            var db = dbConnection();

            var sql = @"SELECT * FROM Aplicante WHERE Correo = @Correo";

            return await db.QueryFirstOrDefaultAsync<Aplicante>(sql, new { Correo = correo });
        }

        public async Task<bool> InsertAplicante(Aplicante aplicante)
        {
            var db = dbConnection();

            var sql = @"INSERT INTO Aplicante (Nombre, ApellidoP, ApellidoM, Correo)
                        VALUES (@Nombre, @ApellidoP, @ApellidoM, @Correo)";

            var result = await db.ExecuteAsync(sql, new { aplicante.Nombre, aplicante.ApellidoP, aplicante.ApellidoM, aplicante.Correo });

            return result > 0;
        }

    }
}
