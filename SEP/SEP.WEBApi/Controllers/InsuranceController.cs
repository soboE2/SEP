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

        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}