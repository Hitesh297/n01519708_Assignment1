using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01519708_assignment1_w2022.Controllers
{
    public class NumberMachineController : ApiController
    {

        /// <summary>
        /// Takes quantity as input and returns cost after discount
        /// </summary>
        /// <param name="id">Takes number as a parameter</param>
        /// <returns>Return a number after calculations</returns>
        /// Example:
        /// /NumberMachine/0 --> 0
        /// /NumberMachine/1 --> 10.1
        /// /NumberMachine/2 --> 20.2
        /// /NumberMachine/4 --> 40.4
        /// /NumberMachine/5 --> 40.4
        public double Get(int id)
        {
            double quantity = id;
            double costOf1IceCream = 10.0;
            double discountRate = Math.Floor(quantity / 5.0);
            //one ice cream free on each buy of 5
            double totalDiscount = costOf1IceCream * discountRate;
            double costWithoutTax = (costOf1IceCream * quantity) - totalDiscount;
            double tax = costWithoutTax * 0.01;
            double total = costWithoutTax + tax;
            
            return total;
        }
    }
}
