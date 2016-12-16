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

        public InsuranceController(IRiskItemServices riskItemServices)
        {
            _riskItemServices = riskItemServices;
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

    }
}