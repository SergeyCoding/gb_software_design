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



            const string V = "ClientId,Name,Birthday";
            var a = GetProperties(item).ToArray();

            using SqliteCommand command =
               new SqliteCommand($"INSERT INTO pets({V}) VALUES(@ClientId,@Name,@Birthday)", connection);

            command.Parameters.AddWithValue("@ClientId", item.ClientId);
            command.Parameters.AddWithValue("@Name", item.Name);
            command.Parameters.AddWithValue("@Birthday", item.Birthday);
            command.Prepare();

            return command.ExecuteNonQuery();
        }

        public IEnumerable<string> GetProperties<T>(T entity)
        {
            return entity!.GetType().GetProperties().Select(p => p.Name).ToList();
        }

        public int Update(Consultation item)
        {
            //using SqliteConnection connection = new SqliteConnection();
            //connection.ConnectionString = _connectionString;
            //connection.Open();
            //using SqliteCommand command =
            //    new SqliteCommand("UPDATE pets SET Document = @Document, FirstName = @FirstName, SurName = @SurName, Patronymic = @Patronymic, Birthday = @Birthday WHERE ClientId=@ClientId", connection);
            //command.Parameters.AddWithValue("@ClientId", item.ClientId);
            //command.Parameters.AddWithValue("@Document", item.Document);
            //command.Parameters.AddWithValue("@SurName", item.SurName);
            //command.Parameters.AddWithValue("@FirstName", item.FirstName);
            //command.Parameters.AddWithValue("@Patronymic", item.Patronymic);
            //command.Parameters.AddWithValue("@Birthday", item.Birthday.Ticks);
            //command.Prepare();
            //return command.ExecuteNonQuery();
            return 0;
        }

        public int Delete(int id)
        {
            return 0;
        }

        public IList<Pet> GetAll()
        {
            throw new NotImplementedException();
        }

        public Pet GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int Update(Pet item)
        {
            throw new NotImplementedException();
        }
    }
}
