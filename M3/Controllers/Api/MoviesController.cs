﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using M3.Models;
using M3.Dtos;
using AutoMapper;
using System.Data.Entity;


namespace M3.Controllers.Api 
{
    public class MoviesController : ApiController
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        public IHttpActionResult GetMovie()
        {
            var movieDtos = _context.Movies.Include(c => c.Genre).ToList().Select(Mapper.Map<Movie, MovieDto>);
            return Ok(movieDtos);
        }

        public MovieDto GetMovie(int id)
        {
            var movie = _context.Movies.SingleOrDefault(c => c.Id == id);
            if (movie == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            return Mapper.Map<Movie, MovieDto>(movie);
        }

        





           [HttpPost]
            public IHttpActionResult CreateMovie(MovieDto movieDto)
             {
                 if (!ModelState.IsValid)
                     throw new HttpResponseException
                         (HttpStatusCode.BadRequest);

                 var movie = Mapper.Map<MovieDto, Movie>(movieDto);
                 _context.Movies.Add(movie);
                 _context.SaveChanges();

                 movieDto.Id = movie.Id;
                 return Created(new Uri(Request.RequestUri + "/" + movie.Id), movieDto);
             }
             
        [HttpPut]
        [Authorize(Roles = RoleName.CanManageMovies)]
        public void UpdateMovie(int id, MovieDto movieDto)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException
                    (HttpStatusCode.BadRequest);
            var movieInDb = _context.Movies.SingleOrDefault(c => c.Id == id);
            if (movieInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);


            Mapper.Map(movieDto, movieInDb);

            _context.SaveChanges();
        }

        [HttpDelete]
        [Authorize(Roles = RoleName.CanManageMovies)]
        public void DeleteMovie(int id)
        {
            var movieInDb = _context.Movies.SingleOrDefault(c => c.Id == id);
            if (movieInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            _context.Movies.Remove(movieInDb);
            _context.SaveChanges();
        }

    }
}
