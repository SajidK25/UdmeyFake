using System;
using System.Collections;
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
    public class TagController : Controller
    {
        private ITagService _tagService;
        public TagController(ITagService tagService)
        {
            _tagService = tagService;
        }
        // GET: api/tag/GetAllTags
        [HttpGet("/api/tag/GetAllTags")]
        public IEnumerable Get()
        {
            return _tagService.GetAllTags();
        }

        // GET api/tag/GetSingleTag
        [HttpGet("/api/tag/GetSingleTag")]
        public ActionResult<Tag> Get(int id)
        {
            var tag = _tagService.GetSingleTag(id);
            return Ok(tag);
        }

        // POST api/tag/AddTag
        [HttpPost("/api/tag/AddTag")]
        public ActionResult Post([FromBody]Tag tag)
        {
            try
            {
                _tagService.AddTag(tag);
                return Ok("New Tag Save Succesfully");
            }
            catch (Exception)
            {
                throw new Exception("Oopps! Something went wrong");
            }
        }

        // PUT api/values/5
        [HttpPut("/api/tag/UpdateTag")]
        public ActionResult Put([FromBody]Tag tag)
        {
            try
            {
                _tagService.UpdateTag(tag);
                return Ok("Updated Successfully");
            }
            catch (Exception)
            {
                throw new Exception("Oopps! Something went wrong");
            }

        }

        // DELETE api/values/5
        [HttpDelete("/api/tag/DeleteTag")]
        public ActionResult Delete([FromBody]Tag tag)
        {
            try
            {
                _tagService.DeleteTag(tag);
                return Ok("Tag Deleted Succesfully");

            }
            catch (Exception)
            {
                throw new Exception("Oopps! Something went wrong");
            }

        }
    }
}
