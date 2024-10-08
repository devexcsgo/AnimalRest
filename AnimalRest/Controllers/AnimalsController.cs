using AnimalLibrary;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AnimalRest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalsController : ControllerBase
    {
        private AnimalRepositoryList _animalRepositoryList;

        public AnimalsController(AnimalRepositoryList animalRepositoryList)
        {
            _animalRepositoryList = animalRepositoryList;
        }

        // GET: api/<AnimalsController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_animalRepositoryList.GetAll());
        }

        // GET api/<AnimalsController>/5
        [HttpGet("{id}")]
        public Animal Get(int id)
        {
            return _animalRepositoryList.GetById(id);
        }

        // POST api/<AnimalsController>
        [HttpPost]
        public Animal Post([FromBody] Animal value)
        {
            return _animalRepositoryList.Add(value);
        }

        // PUT api/<AnimalsController>/5
        [HttpPut("{id}")]
        public Animal Put(int id, [FromBody] Animal value)
        {
            return _animalRepositoryList.Update(id, value);
        }

        // DELETE api/<AnimalsController>/5
        [HttpDelete("{id}")]
        public Animal Delete(int id)
        {
            return _animalRepositoryList.Remove(id);
        }
    }
}
