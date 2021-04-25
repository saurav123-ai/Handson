using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using truYumWebApi.Models;

namespace truYumWebApi.Controllers
{
    public class TrainerController : ApiController
    {
        [HttpPost]
        public HttpResponseMessage TrainerSignUp([FromBody] Trainer t) {


            try
            {

                using (LearnWebApiTodayEntities db = new LearnWebApiTodayEntities())
                {
                    db.Trainers.Add(t);
                    db.SaveChanges();

                    var message = Request.CreateResponse(HttpStatusCode.Created, t);

                    return message;


                }


            }
            catch (Exception ex)
            {

                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);

            }


        }

        [HttpPut]

        public HttpResponseMessage UpdatePassword(int id, [FromBody] Trainer t) {


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

                        entity.Password = t.Password;
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
