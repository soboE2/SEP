using SEP.Contract.Repositories;
using SEP.Contract.ServiceModels;
using SEP.Contract.Services;
using SEP.Service.Helpers;

namespace SEP.Service.Services
{
    public class PriceService : IPriceService
    {
        private readonly IRiskItemRepository _riskItemRepository;

        public PriceService(IRiskItemRepository riskItemRepository)
        {
            _riskItemRepository = riskItemRepository;
        }

        public decimal GetTravelInsurancePrice(TravelRiskItem riskItem)
        {
            var region = _riskItemRepository.GetById(riskItem.RegionID);
            var sport = riskItem.SportId.HasValue ? _riskItemRepository.GetById(riskItem.SportId.Value) : null;

            var workingMemory = RuleBaseHelper.GetWorkingMemoryForRule("TravelInsurancePrice");

            workingMemory.assertObject(region);
            workingMemory.assertObject(sport);
            workingMemory.assertObject(riskItem);

            workingMemory.fireAllRules();

            return riskItem.RuleAmmount;
        }
    }
}