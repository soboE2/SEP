using SEP.Contract.Repositories;
using SEP.Model.Model;
using System.Data.Entity;

namespace SEP.Repository.Repositories
{
    public class InsuranceTypeRepository : BaseRepository<InsuranceType>, IInsuranceTypeRepository
    {
        public InsuranceTypeRepository(DbContext context)
            : base(context)
        {
        }
    }
}