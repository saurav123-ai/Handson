using EmployeeService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace EmployeeService.Controllers
{
    public class CoursesController : ApiController
    {
        static List<course> courses = new List<course>()
        {
             new course()
            {
                CourseId= 1,CourseName="Android",Trainer="Shawn",Fees=12000,CourseDescription="Andriod is a mobile operating system development"
            },
             new course()
            {
                CourseId= 2,CourseName="Asp.Net",Trainer="Kavin",Fees=10000,CourseDescription="Andriod is a mobile operating system development"
            },
              new course()
            {
                CourseId= 3,CourseName="Jsp",Trainer="Shawn",Fees=12000,CourseDescription="Andriod is a mobile operating system development"
            },
               new course()
            {
                CourseId= 4,CourseName="Xamarin.Forms",Trainer="Shawn",Fees=12000,CourseDescription="Andriod is a mobile operating system development"
            }


        };

        public HttpResponseMessage Get(string coursename)
        {
            var result = courses.FirstOrDefault(s => s.CourseName == coursename);
            if(result==null)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Course not found");
            }

            return Request.CreateResponse(HttpStatusCode.OK, result);
        }

        public HttpResponseMessage Post([FromBody] course Course)
        {
            courses.Add(Course);
            return Request.CreateResponse(HttpStatusCode.OK,Course);
        }
    }
}
