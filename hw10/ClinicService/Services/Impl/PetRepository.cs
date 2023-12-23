using ClinicService.Models;
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
            using SqliteConnection connection = new SqliteConnection();
            connection.ConnectionString = _connectionString;
            connection.Open();

            using SqliteCommand command =
               new SqliteCommand($"INSERT INTO pets(ClientId,Name,Birthday) VALUES(@ClientId,@Name,@Birthday)", connection);

            command.Parameters.AddWithValue("@ClientId", item.ClientId);
            command.Parameters.AddWithValue("@Name", item.Name);
            command.Parameters.AddWithValue("@Birthday", item.Birthday);
            command.Prepare();

            return command.ExecuteNonQuery();
        }

        public int Update(Pet item)
        {
            using SqliteConnection connection = new SqliteConnection();
            connection.ConnectionString = _connectionString;
            connection.Open();

            using SqliteCommand command =
                new SqliteCommand("UPDATE pets SET ClientId = @ClientId, Name = @Name, Birthday = @Birthday WHERE PetId=@PetId", connection);

            command.Parameters.AddWithValue("@PetId", item.PetId);
            command.Parameters.AddWithValue("@ClientId", item.ClientId);
            command.Parameters.AddWithValue("@Name", item.Name);
            command.Parameters.AddWithValue("@Birthday", item.Birthday);
            command.Prepare();

            return command.ExecuteNonQuery();
        }

        public Pet GetById(int id)
        {
            using SqliteConnection connection = new SqliteConnection();
            connection.ConnectionString = _connectionString;
            connection.Open();

            using SqliteCommand command =
                new SqliteCommand("SELECT * FROM pets WHERE PetId=@PetId", connection);

            command.Parameters.AddWithValue("@PetId", id);
            command.Prepare();

            SqliteDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                Pet pet = new()
                {
                    PetId = reader.GetInt32(0),
                    ClientId = reader.GetInt32(1),
                    Name = reader.GetString(2),
                    Birthday = reader.GetDateTime(3)
                };
            }

            return null!;
        }

        public int Delete(int id)
        {
            using SqliteConnection connection = new SqliteConnection();
            connection.ConnectionString = _connectionString;
            connection.Open();

            using SqliteCommand command =
                new SqliteCommand("DELETE FROM pets WHERE PetId=@PetId", connection);

            command.Parameters.AddWithValue("@PetId", id);
            command.Prepare();

            return command.ExecuteNonQuery();
        }

        public IList<Pet> GetAll()
        {
            List<Pet> list = [];

            using SqliteConnection connection = new SqliteConnection();
            connection.ConnectionString = _connectionString;
            connection.Open();

            using SqliteCommand command =
                new SqliteCommand("SELECT * FROM pets", connection);
            command.Prepare();

            using SqliteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Pet pet = new()
                {
                    PetId = reader.GetInt32(0),
                    ClientId = reader.GetInt32(1),
                    Name = reader.GetString(2),
                    Birthday = reader.GetDateTime(3)
                };

                list.Add(pet);
            }
            return list;
        }
    }
}
