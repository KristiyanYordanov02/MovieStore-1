using MapsterMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using MovieStore.BL.Interfaces;
using MovieStore.DL.Interfaces;
using MovieStore.Models.DTO;
using MovieStore.Models.Request;
using System.Linq.Expressions;

namespace MovieStore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieService _movieService;
        private readonly IMapper _mapper;
        private readonly ILogger<MoviesController> _logger;

        public MoviesController(
            IMovieService movieService,
            IMapper mapper, 
            ILogger<MoviesController> logger)
        {
            _movieService = movieService;
            _mapper = mapper;
            _logger = logger;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var result = _movieService.GetAllMovies();

            if (result == null || result.Count ==0)
            {
                return NotFound("No movies found");
            }

            return Ok(result);
        }

        [HttpGet("GetById")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetById(int id)
        {
            _logger.LogError(message:$"Getting movie with Id:{id}");
            if (id <=0)
            {
                return BadRequest("Id must be greater than 0");
            }

            var result = _movieService.GetById(id);

            if (result ==null)

            {
                return NotFound($"Movie with ID:{id} not found");


            }
            return Ok(result);
        }
            [HttpPost("Add")]
            public IActionResult Add(AddMovieRequest movie)
            {
                try
                {
                    var movieDTO = _mapper.Map<Movie>(movie);


                    if (movieDTO == null)
                    {
                    return BadRequest("Cant convert movie");
                        }
                }
                catch (Exception ex)
                {
                _logger.LogError(ex, message: $"Error adding movie with:");
                    return BadRequest(ex.Message);
                }
            return Ok();
            }

            [HttpDelete("Delete")]
            public IActionResult Delete(int id)
            {
                if (id <=0)
                {
                    return BadRequest("Id must be greater than 0");
                }
                
            return Ok();
            }

        }
    }

