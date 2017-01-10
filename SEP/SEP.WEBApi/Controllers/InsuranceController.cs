using SEP.Contract.ServiceModels;
using SEP.Contract.Services;
using SEP.WEBApi.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace SEP.WEBApi.Controllers
{
    [RoutePrefix("api/insurance")]
    public class InsuranceController : ApiController
    {
        private readonly IRiskItemServices _riskItemServices;
        private readonly IPriceService _priceService;

        public InsuranceController(IRiskItemServices riskItemServices, IPriceService priceService)
        {
            _riskItemServices = riskItemServices;
            _priceService = priceService;
        }

        [HttpGet]
        [Route("sports")]
        public IEnumerable<RiskItemModel> Sports()
        {
            return _riskItemServices.GetAllSports().Select(m => new RiskItemModel { ID = m.ID, Name = m.Name });
        }

        [HttpGet]
        [Route("regions")]
        public IEnumerable<RiskItemModel> Regions()
        {
            return _riskItemServices.GetAllRegions().Select(m => new RiskItemModel { ID = m.ID, Name = m.Name });
        }

        [HttpPost]
        [Route("travelinsuranceprice")]
        public IHttpActionResult TravelInsurancePrice(TravelInsuranceModel model)
        {
            var riskItem = new TravelRiskItem
            {
                RegionID = model.RegionID,
                NumberOfChildren = model.NumberOfChildren,
                NumberOfAdultsUnder60 = model.NumberOfAdultsUnder60,
                DateFrom = model.DateFrom,
                DateTo = model.DateTo,
                SportId = model.SportId,
                InsuranceAmmount = model.InsuranceAmmount
            };
            return Ok(new { price = _priceService.GetTravelInsurancePrice(riskItem) });
        }
    }
}