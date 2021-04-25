using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MoviesWebApi.Controllers
{
    public class MoviesController : ApiController
    {
        //public string Get()
        //{
        //    return "Hello from Web Api";
        //}

        public List<string> GetMovies()
        {
            return new List<string> { "Titanic", "Mission Impossible", "Matrix" };
        }
    }
}
