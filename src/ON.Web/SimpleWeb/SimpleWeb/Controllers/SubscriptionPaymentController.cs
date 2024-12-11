using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ON.Authentication;
using ON.SimpleWeb.Models.Subscription.Stripe;
using ON.SimpleWeb.Services.Stripe;

namespace ON.SimpleWeb.Controllers
{
    [Authorize]
    [Route("/payment/stripe")]
    public class SubscriptionPaymentController : Controller
    {
        private readonly ILogger logger;
        private readonly PaymentsService paymentsService;
        private readonly ONUserHelper userHelper;

        public SubscriptionPaymentController(ILogger<SubscriptionPaymentController> logger, PaymentsService paymentsService, ONUserHelper userHelper)
        {
            this.logger = logger;
            this.paymentsService = paymentsService;
            this.userHelper = userHelper;
        }

        [HttpGet("check")]
        public async Task<IActionResult> Check()
        {
            var res = await paymentsService.CheckOneTime();

            if (res == null || res.Records.Count == 0)
                return Redirect("/");

            return Redirect("/content/" + res.Records.OrderByDescending(r => r.CreatedOnUTC).FirstOrDefault()?.InternalID.ToString());
        }
    }
}
