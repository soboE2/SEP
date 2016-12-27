using SEP.Contract.Repositories;
using SEP.Contract.Services;

namespace SEP.Service.Services
{
    public class PriceService : IPriceService
    {
        private readonly IRiskItemRepository _riskItemRepository;

        public PriceService(IRiskItemRepository riskItemRepository)
        {
            _riskItemRepository = riskItemRepository;
        }

        public decimal GetTravelInsurancePrice(Contract.ServiceModels.TravelRiskItem riskItem)
        {
            var region = _riskItemRepository.GetById(riskItem.RegionID);




            return default(decimal);
        }
    }
}