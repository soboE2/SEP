using SEP.Contract.Services;
using SEP.Service.Services;
using System;
using System.Web.Mvc;
using System.Linq;

namespace SEP.WEBApi.Controllers
{
    public class HomeController : Controller
    {
        private readonly IInsuranceTypeService _insuranceTypeService;

        public HomeController(IInsuranceTypeService insuranceTypeService)
        {
            _insuranceTypeService = insuranceTypeService;
        }


        public string Index()
        {
            var types = _insuranceTypeService.GetAll();
            return String.Join(",",_insuranceTypeService.GetAll().Select(i => i.Name));
        }
    }
}