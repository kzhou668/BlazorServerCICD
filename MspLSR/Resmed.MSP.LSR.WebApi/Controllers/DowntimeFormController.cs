using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Resmed.MSP.LSR.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Resmed.MSP.LSR.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DowntimeFormController : ControllerBase
    {
        private readonly IDowntimeFormRepo downtimeFormRepo;

        public DowntimeFormController(IDowntimeFormRepo downtimeFormRepo)
        {
            this.downtimeFormRepo = downtimeFormRepo;
        }

        // GET: api/<DowntimeFormController>
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            try
            {
                return Ok(await downtimeFormRepo.GetDowntimeForms());
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        // GET api/<DowntimeFormController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<DowntimeFormController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<DowntimeFormController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DowntimeFormController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
