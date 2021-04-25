using EmployeeService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EmployeeService.Controllers
{
    public class BrandsController : ApiController
    {

        static List<Brand> brands = new List<Brand>()
        {
            new Brand(){BrandId=001,name="Hero" },
            new Brand(){BrandId=002,name="Honda" },
            new Brand(){BrandId=003,name="bajaj" }
        };



        public HttpResponseMessage Post([FromUri]Brand brand)
        {

            

            brands.Add(brand);
           

            return Request.CreateResponse(HttpStatusCode.OK,brand);
        }
    }
}
