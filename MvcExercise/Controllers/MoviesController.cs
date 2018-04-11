﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcExercise.Models;

namespace MvcExercise.Controllers
{
	public class MoviesController : Controller
	{
		// GET: Movies
		public ViewResult Index()
		{
			var movies = GetMovies();

			return View(movies);
		}

		private IEnumerable<Movie> GetMovies()
		{
			return new List<Movie>
			{
				new Movie { Id = 1, Name = "www.brazzers.com" },
				new Movie { Id = 2, Name = "you porn" }
			};
		}
	}
}