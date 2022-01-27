using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;

namespace n01519708_assignment1_w2022.Controllers
{
    public class HostingCostController : ApiController
    {
        public HttpResponseMessage Get(int id)
        {
            const double costPerFortnight = 5.50;
            int fortnights = Convert.ToInt32(Math.Ceiling(((double)id + 1.0) / 14.0));
            double hostingCost = fortnights * costPerFortnight;
            double hst = hostingCost * 0.13;
            double total = hostingCost + hst;

            var response = new HttpResponseMessage();
            response.Content = new StringContent($"<div>{fortnights} fortnights at $5.50/FN = ${hostingCost.ToString("0.00")} CAD</div><div>HST 13 % = ${hst.ToString("0.00")} CAD</div><div>Total = ${total.ToString("0.00")} CAD</div>");
            response.Content.Headers.ContentType = new MediaTypeHeaderValue("text/html");
            return response;
        }
    }
}
