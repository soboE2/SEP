using SEP.Contract.Repositories;
using SEP.Model.Model;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace SEP.Repository.Repositories
{
    public class RiksItemRepository : BaseRepository<RiskItem>, IRiskItemRepository
    {
        public RiksItemRepository(DbContext context)
            : base(context)
        {
        }

        public IEnumerable<RiskItem> GetAllByRiskId(int id)
        {
            return _dbSet.Where(ri => ri.Risk.ID == id) ?? Enumerable.Empty<RiskItem>();
        }
    }
}