using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01519708_assignment1_w2022.Controllers
{
    /// <summary>
    /// This class is used to do some random calculation
    /// </summary>
    public class NumberMachineController : ApiController
    {

        /// <summary>
        /// Takes number as an input and does a fake billing calculation
        /// </summary>
        /// <param name="id">Takes number as a parameter</param>
        /// <returns>Return a decimal number after calculations</returns>
        public decimal Get(int id)
        {
            int quantity = id;
            int costOf1IceCream = 10;
            decimal totalDiscount = 2 * (quantity/5);
            decimal costWithoutTax = (costOf1IceCream * quantity) - totalDiscount;
            decimal tax = costWithoutTax * 0.01M;
            decimal total = costWithoutTax + tax;
            decimal costPerPerson = total / id;
            
            return costPerPerson;
        }
    }
}
