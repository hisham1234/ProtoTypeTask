
using Dapper;
using Npgsql;
using System.Data;

namespace PharmacyAPI.Database
{
    public class DatabaseContext: IDbService
    {
        private readonly IDbConnection _db;

        public DatabaseContext(IConfiguration configuration)
        {
            this._db = new NpgsqlConnection(configuration.GetConnectionString("PharmacyDb"));
            
        }

        public async Task<List<T>> GetAll<T>(string command, object parms)
        {

            List<T> result = new List<T>();

            result = (await _db.QueryAsync<T>(command, parms)).ToList();

            return result;
        }

    }

    
}
