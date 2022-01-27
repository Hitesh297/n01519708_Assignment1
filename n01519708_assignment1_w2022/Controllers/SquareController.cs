using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01519708_assignment1_w2022.Controllers
{
    /// <summary>
    /// This class does square
    /// </summary>
    public class SquareController : ApiController
    {

        /// <summary>
        /// Takes a number as a parameter and returns the square of it.
        /// </summary>
        /// <param name="id">Takes a number as a parameter</param>
        /// <returns>Returns the square of the input parameter</returns>
        /// GET localhost/Square/2 --> 4
        /// GET localhost/Square/-2 --> 4
        /// GET localhost/Square/10 --> 100
        public int Get(int id)
        {
            int square = id * id;
            return square;
        }
    }
}
