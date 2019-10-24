using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UdemyAPI.Core;
using UdemyAPI.Library.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UdemyAPI.Controllers
{
    [Route("api/[controller]")]
    public class CourseController : Controller
    {
        private ICourseService _courseService;
        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }
        // GET: api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/course/GetAllTags
        [HttpPost("/api/course/AddCourse")]
        public ActionResult Post([FromBody]Course course)
        {
            try
            {
                _courseService.AddCourse(course);
                return Ok("Course added Success fully");
            }
            catch (Exception)
            {
                throw new Exception("Ooopps something went wrong");
            }

        }

        // Get api/course/GetAllTagsOfACourse
        [HttpGet("/api/course/GetAllTagsOfACourse")]
        public ActionResult GetTagsOfCourse(int courseId)
        {
            try
            {
                var tags = _courseService.GetAllTagsOfACourse(courseId);
                return Ok(tags);

            }
            catch (Exception)
            {
                throw new Exception("Ooopps something went wrong");
            }
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
