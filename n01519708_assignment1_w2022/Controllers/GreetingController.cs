using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01519708_assignment1_w2022.Controllers
{
    /// <summary>
    /// This class is used to greet user
    /// </summary>
    public class GreetingController : ApiController
    {

        /// <summary>
        /// Accepts a post request and returns a string
        /// </summary>
        /// <returns>Returns "Hello World!" string</returns>
        /// POST localhost/Greeting --> "Hello World!"
        public string Post()
        {
            string greeting = "Hello World!";
            return greeting;
        }


        /// <summary>
        /// Accepts a number as a parameter and generates a greeting message based on it.
        /// </summary>
        /// <param name="id">Takes number as a parameter</param>
        /// <returns>Returns a string based on input parameter</returns>
        /// GET localhost/Greeting/3 --> Greetings to 3 people!
        /// GET localhost/Greeting/6 --> Greetings to 6 people!
        /// GET localhost/Greeting/0  --> Greetings to 0 people!
        public string Get(int id)
        {
            string greeting = $"Greetings to {id} people!";
            return greeting;
        }
    }
}
