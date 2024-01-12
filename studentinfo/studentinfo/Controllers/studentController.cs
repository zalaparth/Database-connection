using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using studentinfo.models;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace studentinfo.Controllers
{
    [Route("students")]
    public class studentController : Controller
    {
        private readonly Contextdb db;
        public studentController(Contextdb db)
        {
            this.db = db;
        }
        [HttpPost]
        public student adddata([FromBody]student student)
        {
            db.student.InsertOne(student);
            return student;
        }
        [HttpGet]
        public List<student> getdata()
        {
            return db.student.AsQueryable().ToList();
             
        }
    }
}
