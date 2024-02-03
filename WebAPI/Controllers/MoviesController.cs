using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController] //C# => Attribute Java => Annotation
    public class MoviesController : ControllerBase
    {
        IMovieService _movieService; //loosely coupled

        public MoviesController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        [HttpGet]
        public List<Movie> Get()
        {
            var result = _movieService.GetAll().ToList();
            return result;
            
        }

        [HttpPost]
        public IActionResult Post(Movie movie)
        {
            _movieService.Add(movie);
            return Ok();
        }
    }
}
