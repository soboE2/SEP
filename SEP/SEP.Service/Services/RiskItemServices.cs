using SEP.Contract.Repositories;
using SEP.Contract.Services;
using SEP.Model.Model;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace SEP.Service.Services
{
    public class RiskItemServices : BaseService<RiskItem>, IRiskItemServices
    {
        private readonly IRiskItemRepository _riskItemRepository;
        private readonly IRiskRepository _riskRepository;
        private readonly DbContext _dbContext;

        public RiskItemServices(IRiskItemRepository riskItemRepository, IRiskRepository riskRepository, DbContext dbContext)
            : base(riskItemRepository)
        {
            _riskItemRepository = riskItemRepository;
            _riskRepository = riskRepository;
            _dbContext = dbContext;
        }

        public IEnumerable<RiskItem> GetAllSports()
        {
            var sportRisk = _riskRepository.GetAll().Where(m => m.Name.Equals("Sport")).FirstOrDefault();
            
            var sports = sportRisk != null ? _riskItemRepository.GetAllByRiskId(sportRisk.ID) : Enumerable.Empty<RiskItem>();
            
            return sports;
        }
    }
}