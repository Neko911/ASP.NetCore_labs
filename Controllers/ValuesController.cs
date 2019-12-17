using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
//////////////////
///
//GET: api/values?start=1&end=5
// GET: api/value/1
// POST: api/value
// DELETE: api/values/1
// PUT: api/value/1
/////////////////
namespace WebApplication13.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : Controller
    {
        // GET: /<controller>/
        //public IActionResult Index()
        //{
        //    return View();
        //}

        public readonly IDataManager _dataManager;

        public ValuesController(IDataManager dataManager)
        {
            _dataManager = dataManager;
        }
        //GET: api/values?start=1&end=5
        [HttpGet]
        public IActionResult Get([FromQuery] int start, [FromQuery] int end)
        {

            if (start >= 0 && end >= 1 && start < end)
            {
                return Ok(_dataManager.GenerateNumber(start, end));
            }
            else
            {
                return Ok(_dataManager.GenerateNumber());
            }

        }
        // GET: api/values/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            if (_dataManager.GenerateNumber_Id(id) > 0)
            {
                return Ok(_dataManager.GenerateNumber_Id(id));
            }
            else
            {
                return BadRequest(id);
            }
        }
        // POST: api/values
        [HttpPost]
        public IActionResult Post([FromBody] int value)
        {
            if (_dataManager.GenerateNumber_Post(value))
            {
                return StatusCode(201, value);
            }
            else
            {
                return BadRequest();
            }
        }
        // PUT: api/values/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] int value)
        {
            if (_dataManager.GenerateNumber_Put(id, value))
            {
                return StatusCode(201, id);
            }
            else
            {
                return StatusCode(422);
            }
        }
        // DELETE: api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (_dataManager.GenerateNumber_Delete(id))
            {
                return StatusCode(204, id);
            }
            else
            {
                return StatusCode(422);
            }
        }

    }
}
