using AsuransiXYZ.Provider;
using Microsoft.AspNetCore.Mvc;

namespace AnsuransiXYZ.Web.Controllers
{
    public class ProspectController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var model = ProspectProvider.GetProvider().GetAllIndex();
            //ProspectProvider.GetProvider().GetApidanAir();
            //ProspectProvider.GetProvider().GetAPIyuk();

            return View(model);
        }
    }
}
