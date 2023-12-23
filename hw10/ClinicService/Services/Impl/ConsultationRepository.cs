using ClinicService.Models;

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
            throw new NotImplementedException();
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

        public int Update(Consultation item)
        {
            throw new NotImplementedException();
        }
    }
}
