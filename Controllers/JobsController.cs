using System;
using Jobbr.Models;
using Jobbr.Services;
using Microsoft.AspNetCore.Mvc;

namespace Jobbr.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class JobsController : ControllerBase
    {
        private readonly JobsService _service;

        public JobsController(JobsService js)
        {
            _service = js;
        }

        [HttpGet]
        public ActionResult<Job> Get()
        {
            try
            {
               return Ok(_service.GetAll()); 
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpGet("{id}")]
        public ActionResult<Job> Get(int id)
        {
            try
            {
               return Ok(_service.GetById(id)); 
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }  
        }
        [HttpPost]
        public ActionResult<Job> Create([FromBody] Job newJob)
        {
            try
            {
                return Ok(_service.Create(newJob));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpPut]
        public ActionResult<Job> Edit([FromBody] Job updated, int id)
        {
            try
            {
                return Ok(_service.Edit(updated));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}