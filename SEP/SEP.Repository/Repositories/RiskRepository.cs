using SEP.Contract.Repositories;
using SEP.Model.Model;
using System.Data.Entity;

namespace SEP.Repository.Repositories
{
    public class RiskRepository : BaseRepository<Risk>, IRiskRepository
    {
        public RiskRepository(DbContext context)
            : base(context)
        {
        }
    }
}