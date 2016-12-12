using SEP.Contract.Services;
using SEP.Service.Services;
using System;
using System.Web.Mvc;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;

namespace SEP.WEBApi.Controllers
{
    public class HomeController : Controller
    {
        private readonly IInsuranceTypeService _insuranceTypeService;

        public HomeController(IInsuranceTypeService insuranceTypeService)
        {
            _insuranceTypeService = insuranceTypeService;
        }
        
        public ActionResult Index()
        {
            return File(Server.MapPath("/Views/Home/Index.html"), "text/html");
        }
    }
}