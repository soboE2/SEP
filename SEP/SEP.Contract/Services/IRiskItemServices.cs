using SEP.Model.Model;
using System.Collections.Generic;

namespace SEP.Contract.Services
{
    public interface IRiskItemServices : IBaseService<RiskItem>
    {
        IEnumerable<RiskItem> GetAllSports();
    }
}