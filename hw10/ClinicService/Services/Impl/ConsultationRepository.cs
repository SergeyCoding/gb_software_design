using ClinicService.Models;
using Microsoft.Data.Sqlite;

namespace ClinicService.Services.Impl
{
    public class ConsultationRepository : IConsultationRepository
    {
        private readonly string _connectionString;

        public ConsultationRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("db")!;
        }

        public int Create(Consultation item)
        {
            using SqliteConnection connection = new SqliteConnection();
            connection.ConnectionString = _connectionString;
            connection.Open();

            using SqliteCommand command =
               new SqliteCommand("INSERT INTO consultations(ClientId,PetId,ConsultationDate,Description) VALUES(@ClientId,@PetId,@ConsultationDate,@Description)", connection);

            command.Parameters.AddWithValue("@ClientId", item.ClientId);
            command.Parameters.AddWithValue("@PetId", item.PetId);
            command.Parameters.AddWithValue("@ConsultationDate", item.ConsultationDate);
            command.Parameters.AddWithValue("@Description", item.Description);
            command.Prepare();
            return command.ExecuteNonQuery();
        }

        public int Update(Consultation item)
        {
            using SqliteConnection connection = new SqliteConnection();
            connection.ConnectionString = _connectionString;
            connection.Open();
            using SqliteCommand command =
                new SqliteCommand("UPDATE consultations SET ConsultationId=@ConsultationId, ClientId=@ClientId, PetId=@PetId, ConsultationDate=@ConsultationDate, Description=@Description", connection);
            command.Parameters.AddWithValue("@ConsultationId", item.ConsultationId);
            command.Parameters.AddWithValue("@ClientId", item.ClientId);
            command.Parameters.AddWithValue("@PetId", item.PetId);
            command.Parameters.AddWithValue("@ConsultationDate", item.ConsultationDate);
            command.Parameters.AddWithValue("@Description", item.Description);
            command.Parameters.
            command.Prepare();
            return command.ExecuteNonQuery();
        }

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Consultation> GetAll()
        {
            throw new NotImplementedException();
        }

        public Consultation GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
