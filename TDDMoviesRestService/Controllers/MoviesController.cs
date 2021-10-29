using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TDDMoviesRestService.Managers;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TDDMoviesRestService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private MoviesManager _manager = new MoviesManager();

        // GET: api/<MoviesController>
        [HttpGet]
        public int GetTotalNumberOfMovies()
        {
           var result = _manager.GetMovies().Count();
            return result;
        }

        // GET api/<MoviesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<MoviesController>
        [HttpPost]
        public Movie Post([FromBody] Movie movie)
        {
            Movie newMovie = _manager.AddNewMovie(movie);
            return newMovie;
        }

        // PUT api/<MoviesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MoviesController>/5
        [HttpDelete("{id}")]
        public Movie Delete(string title)
        {
            Movie deletedMovie = _manager.DeleteMovie(title);
            return deletedMovie;

        }
    }
}
