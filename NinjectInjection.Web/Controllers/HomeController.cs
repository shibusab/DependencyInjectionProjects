using Billing.CoreAndInfra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NinjectInjection.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBillingQueryRepository billingQueryRepository;

        public HomeController(IBillingQueryRepository billingQueryRepository)
        {
            this.billingQueryRepository = billingQueryRepository;
        }
        public ActionResult Index()
        {
            var bills= billingQueryRepository.GetShippingBills("UPS");
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}