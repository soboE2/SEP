using SEP.Model.Model;
using System.Collections.Generic;

namespace SEP.Contract.Repositories
{
    public interface IRiskItemRepository : IBaseRepository<RiskItem>
    {
        IEnumerable<RiskItem> GetAllByRiskId(int id);
    }
}