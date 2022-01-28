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
        /// <summary>
        /// Calculates & decribes the cost of hosting and maintainance based on number of days
        /// </summary>
        /// <param name="id">Number of days elapsed since the beginning of the hosting</param>
        /// <returns>Hosting cost details based on input</returns>
        /// Example:
        /// GET /HostingCost/0 ==>
        /// “1 fortnights at $5.50/FN = $5.50 CAD”
        /// “HST 13% = $0.72 CAD” 
        /// “Total = $6.22 CAD”
        /// =============================================
        /// GET /HostingCost/14 ==>
        /// “2 fortnights at $5.50/FN = $11.00 CAD”
        /// “HST 13% = $1.43 CAD”
        /// “Total = $12.43 CAD”
        /// =============================================
        /// GET /HostingCost/15 ==>
        /// “2 fortnights at $5.50/FN = $11.00 CAD”
        /// “HST 13% = $1.43 CAD”
        /// “Total = $12.43 CAD”
        /// =============================================
        /// GET /HostingCost/21 ==>
        /// “2 fortnights at $5.50/FN = $11.00 CAD”
        /// “HST 13% = $1.43 CAD”
        /// “Total = $12.43 CAD”
        /// =============================================
        /// GET /HostingCost/28 ==>
        /// “3 fortnights at $5.50/FN = $16.50 CAD”
        /// “HST 13% = $2.14 CAD”
        /// “Total = $18.64 CAD”
        public HttpResponseMessage Get(int id)
        {
            const double costPerFortnight = 5.50;
            int fortnights = Convert.ToInt32(Math.Ceiling(((double)id + 1.0) / 14.0));
            double hostingCost = Math.Round((fortnights * costPerFortnight),2);
            double hst = Math.Round((hostingCost * 0.13),2);
            double total = Math.Round((hostingCost + hst),2);

            //used HttpResponseMessage to add header as html, to let browser know that the response data
            //is of type HTML so that we can see strings in 3 different lines
            var response = new HttpResponseMessage();
            response.Content = new StringContent($"<div>{fortnights} fortnights at $5.50/FN = ${hostingCost.ToString("0.00")} CAD</div><div>HST 13 % = ${hst.ToString("0.00")} CAD</div><div>Total = ${total.ToString("0.00")} CAD</div>");
            response.Content.Headers.ContentType = new MediaTypeHeaderValue("text/html");
            return response;
        }
    }
}
