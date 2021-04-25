using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using truYumWebApi.Models;

namespace truYumWebApi.Controllers
{
    public class StudentController : ApiController
    {

        [HttpGet]
        public IEnumerable<Course> GetAllCourses()
        {

            LearnWebApiTodayEntities db = new LearnWebApiTodayEntities();
            

                return db.Courses.OrderBy(s => s.Start_Date).ToList();

           

        }

        public HttpResponseMessage PostStudent([FromBody] Student student)
        {

            try
            {

                using (LearnWebApiTodayEntities db = new LearnWebApiTodayEntities())
                {
                    db.Students.Add(student);
                    db.SaveChanges();

                    var message = Request.CreateResponse(HttpStatusCode.Created, student);

                    return message;


                }


            }
            catch (Exception e)
            {

                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, e);

            }
        }


        public HttpResponseMessage DeleteStudentEnrollment(int id)
        {

            try
            {

                using (LearnWebApiTodayEntities db = new LearnWebApiTodayEntities())
                {
                    var entity = db.Students.FirstOrDefault(s => s.StudentId == id);

                    if (entity == null)
                    {

                        return Request.CreateErrorResponse(HttpStatusCode.NotFound,
                                                "No Enrollment Information Found");

                    }
                    else
                    {

                        db.Students.Remove(entity);

                        db.SaveChanges();

                        return Request.CreateResponse(HttpStatusCode.OK);

                    }
                }


            }
            catch (Exception e)
            {

                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, e);

            }


        }
    }
}
