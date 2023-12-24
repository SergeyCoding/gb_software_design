using ClinicService.Models;
using Dapper;
using Microsoft.Data.Sqlite;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;

namespace ClinicService.Services.Impl
{
    public class ConsultationRepository : IConsultationRepository
    {
        private readonly string _connectionString;
        private readonly Assembly _assembly;
        private readonly string _ns;

        public ConsultationRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("db")!;
            _assembly = GetType().Assembly;
            _ns = GetType().Namespace!;
        }

        public int Create(Consultation item)
        {
            using var connection = new SqliteConnection(_connectionString);
            var sql = GetSql();
            return connection.Execute(sql, item);
        }

        public int Update(Consultation item)
        {
            using var connection = new SqliteConnection(_connectionString);
            var sql = GetSql();
            return connection.Execute(sql, item);
        }

        public int Delete(int id)
        {
            using var connection = new SqliteConnection(_connectionString);
            var sql = GetSql();
            return connection.Execute(sql, new { ConsultationId = id });
        }

        public IList<Consultation> GetAll()
        {
            using var connection = new SqliteConnection(_connectionString);
            var sql = GetSql();
            return connection.Query<Consultation>(sql).ToArray();
        }

        public Consultation GetById(int id)
        {
            using var connection = new SqliteConnection(_connectionString);
            var sql = GetSql();
            return connection.QuerySingle<Consultation>(sql, new { ConsultationId = id });
        }


        private string GetSql([CallerMemberName] string sqlName = "")
        {
            var stream = _assembly.GetManifestResourceStream($"{_ns}.{nameof(ConsultationRepository)}.{sqlName}.sql")!;
            var streamReader = new StreamReader(stream, Encoding.UTF8);
            return streamReader.ReadToEnd();
        }
    }
}
