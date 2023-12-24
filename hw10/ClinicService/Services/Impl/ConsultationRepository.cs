using ClinicService.Models;
using Dapper;
using Microsoft.Data.Sqlite;
using System.Text;

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
            using var connection = new SqliteConnection(_connectionString);

            var sql = "INSERT INTO consultations(ClientId,PetId,ConsultationDate,Description)"
                + " VALUES(@ClientId,@PetId,@ConsultationDate,@Description)";

            return connection.Execute(sql, item);
        }

        public int Update(Consultation item)
        {
            using var connection = new SqliteConnection(_connectionString);

            var sql = "UPDATE consultations " +
                "SET ClientId=@ClientId, PetId=@PetId, ConsultationDate=@ConsultationDate, Description=@Description " +
                "where ConsultationId=@ConsultationId";

            return connection.Execute(sql, item);
        }

        public int Delete(int id)
        {
            using var connection = new SqliteConnection(_connectionString);

            var sql = "DELETE FROM consultations WHERE ConsultationId=@ConsultationId ";

            return connection.Execute(sql, new { ConsultationId = id });
        }

        public IList<Consultation> GetAll()
        {
            using var connection = new SqliteConnection(_connectionString);

            var sql = "select * from consultations";

            return connection.Query<Consultation>(sql).ToArray();
        }

        public Consultation GetById(int id)
        {

            using var connection = new SqliteConnection(_connectionString);

            var sql = GetSql("select.sql");// "select * from consultations where ConsultationId=@ConsultationId";

            return connection.QuerySingle<Consultation>(sql, new { ConsultationId = id });
        }

        private string GetSql(string sqlName)
        {
            var ns = GetType().Namespace;
            var stream = GetType().Assembly.GetManifestResourceStream($"{ns}.{nameof(ConsultationRepository)}.{sqlName}")!;
            var streamReader = new StreamReader(stream, Encoding.UTF8);
            return streamReader.ReadToEnd();
        }
    }
}
