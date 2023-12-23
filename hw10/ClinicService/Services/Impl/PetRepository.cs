using ClinicService.Models;
using Dapper;
using Microsoft.Data.Sqlite;

namespace ClinicService.Services.Impl
{
    public class PetRepository : IPetRepository
    {
        private readonly string _connectionString;

        public PetRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("db")!;
        }


        public int Create(Pet item)
        {
            using var connection = new SqliteConnection(_connectionString);

            var sql = "INSERT INTO pets(ClientId,Name,Birthday) VALUES(@ClientId,@Name,@Birthday)";

            return connection.Execute(sql, item);
        }

        public int Update(Pet item)
        {
            using SqliteConnection connection = new SqliteConnection(_connectionString);

            const string sql = "UPDATE pets SET ClientId = @ClientId, Name = @Name, Birthday = @Birthday WHERE PetId=@PetId";

            return connection.Execute(sql, item);
        }

        public Pet GetById(int id)
        {
            using SqliteConnection connection = new SqliteConnection(_connectionString);

            const string sql = "SELECT * FROM pets WHERE PetId=@PetId";

            return connection.QuerySingle<Pet>(sql, new { PetId = id });
        }

        public int Delete(int id)
        {
            using SqliteConnection connection = new SqliteConnection(_connectionString);

            const string sql = "DELETE FROM pets WHERE PetId=@PetId";

            return connection.Execute(sql, new { PetId = id });
        }

        public IList<Pet> GetAll()
        {
            using SqliteConnection connection = new SqliteConnection(_connectionString);

            const string sql = "SELECT * FROM pets";

            return connection.Query<Pet>(sql).ToList();
        }
    }
}
