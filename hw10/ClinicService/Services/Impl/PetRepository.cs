using ClinicService.Models;

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
            throw new NotImplementedException();
        }

        public int Delete(int id)
        {
            throw new NotImplementedException();
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
