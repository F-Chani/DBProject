using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Solid.Core.Models;
using Solid.Core.Services;
using System.Xml.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProjectApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuyController : ControllerBase
    {
        private readonly IGuyService _guyService;
        public GuyController(IGuyService guyService)
        {
            _guyService = guyService;
        }


        // GET: api/<GuyController>
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_guyService.GetAll());
        }

        // GET api/<GuyController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            return Ok(_guyService.Get(id));   
        }
        //[HttpGet("{age}")]
        //public IEnumerable<Guy> GetAge(int age)
        //{
        //    return contaxt.guys.Where(x => x.Age == age);
        //}

        // POST api/<GuyController>
        [HttpPost]
        public void Post([FromBody] Guy value)
        {
            _guyService.Post(value);
        }

        // PUT api/<GuyController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Guy value)
        {
            _guyService.put(id, value); 
        }

        // DELETE api/<GuyController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _guyService.Delete(id);
        }
    }
}
