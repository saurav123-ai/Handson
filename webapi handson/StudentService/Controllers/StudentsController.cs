using StudentService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace StudentService.Controllers
{
    public class StudentsController : ApiController
    {
        //public IEnumerable<Student> Get()
        //{
        //    using (StudentDBEntities dbcontext = new StudentDBEntities())
        //    {
        //        return dbcontext.Students.ToList();
        //    }
        //}


        //public Student Get(int id)
        //{
        //    using (StudentDBEntities dbcontext = new StudentDBEntities())
        //    {
        //        return dbcontext.Students.FirstOrDefault(x => x.Id == id);
        //    }
        //}


        public HttpResponseMessage Get()
        {
            using (StudentDBEntities dbcontext = new StudentDBEntities())
            {
                return Request.CreateResponse(HttpStatusCode.OK, dbcontext.Students.ToList());
            }
        }

        //public HttpResponseMessage Get (int id)
        //{
        //    using (StudentDBEntities dbcontext = new StudentDBEntities())
        //    {
        //        var entity= dbcontext.Students.FirstOrDefault(x => x.Id == id);
        //        if(entity!=null)
        //        {
        //            return Request.CreateResponse(HttpStatusCode.OK, entity);
        //        }
        //        else
        //        {
        //            return Request.CreateErrorResponse(HttpStatusCode.NotFound, "$ student with {id} is not found");
        //        }
        //    }
        //}



        //public void Put(int id, [FromBody] Student student)
        //{
        //    using (StudentDBEntities dbcontext = new StudentDBEntities())
        //    {
        //        var entity= dbcontext.Students.FirstOrDefault(x => x.Id == id);
        //        entity.FirstName = student.FirstName;
        //        entity.LastNamer = student.LastNamer;
        //        entity.Gender = student.Gender;
        //        entity.Address = student.Address;

        //        dbcontext.SaveChanges();

        //    }
        //}


        public HttpResponseMessage Put(int id, [FromBody] Student student)
        {
            using (StudentDBEntities dbcontext = new StudentDBEntities())
            {
                var entity = dbcontext.Students.FirstOrDefault(x => x.Id == id);
                entity.FirstName = student.FirstName;
                entity.LastNamer = student.LastNamer;
                entity.Gender = student.Gender;
                entity.Address = student.Address;

                dbcontext.SaveChanges();

                return Request.CreateResponse(HttpStatusCode.OK, entity);

            }

        }

        //public HttpResponseMessage Put(int id, [FromBody] Student student)
        //{
        //    try
        //    {
        //        using (StudentDBEntities dbcontext = new StudentDBEntities())
        //        {
        //            var entity = dbcontext.Students.FirstOrDefault(x => x.Id == id);
        //            if(entity==null)
        //            {
        //                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Student with id" + id.ToString() + "not found to update");
        //            }

        //            else
        //            {
        //                entity.FirstName = student.FirstName;
        //                entity.LastNamer = student.LastNamer;
        //                entity.Gender = student.Gender;
        //                entity.Address = student.Address;

        //                dbcontext.SaveChanges();

        //                return Request.CreateResponse(HttpStatusCode.OK, entity);
        //            }

        //        }

        //    }
        //    catch(Exception ex)
        //    {
        //        return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
        //    }


        //}

        public void Post([FromBody] Student student)
        {
            using (StudentDBEntities dbcontext = new StudentDBEntities())
            {
                dbcontext.Students.Add(student);
                dbcontext.SaveChanges();
            }

        }


        //public HttpResponseMessage Post([FromBody] Student student)
        //{
        //    try
        //    {
        //        using (StudentDBEntities dbcontext = new StudentDBEntities())
        //        {
        //            dbcontext.Students.Add(student);
        //            dbcontext.SaveChanges();
        //            var message = Request.CreateResponse(HttpStatusCode.Created, student);

        //            return message;
        //        }
        //    }

        //    catch (Exception ex)
        //    {
        //        return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
        //    }

        //}


        public void Delete(int id)
        {

            using (StudentDBEntities dbcontext = new StudentDBEntities())
            {
                dbcontext.Students.Remove(dbcontext.Students.FirstOrDefault(x => x.Id == id));
                dbcontext.SaveChanges();
            }
        }

        //public HttpResponseMessage Delete(int id)
        //{
        //    using (StudentDBEntities dbcontext = new StudentDBEntities())
        //    {
        //        var entity = dbcontext.Students.FirstOrDefault(x => x.Id == id);
        //        dbcontext.Students.Remove(entity);
        //        dbcontext.SaveChanges();
        //        return Request.CreateResponse(HttpStatusCode.OK);
        //    }
        //}



    }
}
