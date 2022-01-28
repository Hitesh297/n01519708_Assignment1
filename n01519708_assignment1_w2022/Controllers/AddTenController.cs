using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01519708_assignment1_w2022.Controllers
{
    public class AddTenController : ApiController
    {

        /// <summary>
        /// Takes a number as a parameter and returns a value by adding 10 to the parameter value
        /// </summary>
        /// <param name="id">Takes a number as parameter</param>
        /// <returns>Return a value by adding 10 to the input</returns>
        /// GET AddTen/21 --> 31
        /// GET AddTen/0 --> 10
        /// GET AddTen/-9 --> 1
        public int Get(int id)
        {
            const int number = 10;
            int sum = id + number;
            return sum;
        }
     
    }
}
