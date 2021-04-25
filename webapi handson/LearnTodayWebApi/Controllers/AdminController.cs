using LearnTodayWebApi.Models;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace truYumWebApi.Controllers
{
    public class AdminController : ApiController
    {
        LearnWebApiTodayEntities db = new LearnWebApiTodayEntities();
        public IEnumerable<Course> GetAllCourses()
        {
            return db.Courses.ToList();
        }
        public HttpResponseMessage GetCourseById(int id)
        {
            var entity = db.Courses.FirstOrDefault(c => c.CourseId == id);
            if (entity != null)
                return Request.CreateResponse(HttpStatusCode.OK, entity);
            else
                return Request.CreateResponse(HttpStatusCode.NotFound, $"Search Data not Found");
        }
    }
}
