using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RegFormApi.Model;

namespace RegFormApi.Controllers.Api
{
    [Route("api/persons")]
    [ApiController]
    public class PersonsController : Controller
    {
        private readonly RegFormApiDbContext context;

        public PersonsController( RegFormApiDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var personDb = context.Persons.ToList();

            return Ok(personDb);
        }

        [HttpPost]
        public IActionResult Create(Person person)
        {
            context.Add(person);
            context.SaveChanges();

            return Ok();
        }
    }
}
