using LearnTodayWebApi.Models;
using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace truYumWebApi.Controllers
{
    public class TrainerController : ApiController
    {
        [HttpPost]
        public HttpResponseMessage TrainerSignUp([FromBody] Trainer trainer)
        {


            try
            {

                using (LearnWebApiTodayEntities db = new LearnWebApiTodayEntities())
                {
                    db.Trainers.Add(trainer);
                    db.SaveChanges();

                    var message = Request.CreateResponse(HttpStatusCode.Created, trainer);

                    return message;


                }


            }
            catch (Exception ex)
            {

                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);

            }


        }

        [HttpPut]

        public HttpResponseMessage UpdatePassword(int id, [FromBody] Trainer t)
        {


            try
            {

                using (LearnWebApiTodayEntities db = new LearnWebApiTodayEntities())
                {
                    var entity = db.Trainers.FirstOrDefault(s => s.TrainerId == id);

                    if (entity == null)
                    {

                        return Request.CreateErrorResponse(HttpStatusCode.NotFound,
                                                "Searched Data Not Found");
                    }
                    else
                    {

                        entity.password = t.password;
                        db.SaveChanges();

                        return Request.CreateResponse(HttpStatusCode.OK, "Data Updated Successfully");

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
