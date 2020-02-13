using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebKUR.Dtos;
using WebKUR.Models;
using System.Data.Entity;

namespace WebKUR.Controllers.Api
{
    public class MovieController : ApiController
    {
         private ApplicationDbContext  _context;
        public MovieController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: api/Movie
        public IEnumerable<MovieDto> GetMovie(string query = null)
        {
            var moviesQuery = _context.Movies
                .Include(m => m.Genre)
                .Where(m => m.NumberAvaliable > 0);

            if (!String.IsNullOrWhiteSpace(query))
            {
                moviesQuery = moviesQuery.Where(c => c.Name.Contains(query));
            }
       
                return moviesQuery
                 .ToList()
                 .Select(Mapper.Map<Movie, MovieDto>);
        }

        // GET: api/Movie/5
        public IHttpActionResult GetMovie(int id)
        {
            var movie = _context.Movies.SingleOrDefault(c => c.Id == id);

            if (movie == null)
                return NotFound();

            return Ok(Mapper.Map<Movie, MovieDto>(movie));
        }

        // POST: api/Movie
        [HttpPost]
        public IHttpActionResult CreateMovie(MovieDto movieDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var movie = Mapper.Map<MovieDto, Movie>(movieDto);
            _context.Movies.Add(movie);
            _context.SaveChanges();

            movieDto.Id = movie.Id;
            return Created(new Uri(Request.RequestUri + "/" + movie.Id), movieDto);
        }


        // PUT: api/Movie/5
        [HttpPut]
        public IHttpActionResult UpdateMovie(int id , MovieDto moviedto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var movieInDb = _context.Movies.SingleOrDefault(x => x.Id == id);
            if (movieInDb == null)
            NotFound();

            Mapper.Map(moviedto, movieInDb);
            _context.SaveChanges();
            return Ok();
        }

        // DELETE: api/Movie/5
        [HttpDelete]
        public IHttpActionResult DeleteMovie(int id)
        {
            var movie = _context.Movies.SingleOrDefault(x => x.Id == id);
            if (movie == null)
                return NotFound();
            _context.Movies.Remove(movie);
            _context.SaveChanges();
            return Ok();
        }
    }
}
