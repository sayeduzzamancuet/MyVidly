using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using MyVidly.Models;
using MyVidly.ViewModel;

namespace MyVidly.Controllers
{
	public class MovieController : Controller
	{
		private ApplicationDbContext _context;

		public MovieController()
		{
			_context = new ApplicationDbContext();
		}

		protected override void Dispose(bool disposing)
		{
			_context.Dispose();
		}
		//
		// GET: /Movie/
		public ActionResult Index()
		{
			var movieList = _context.Movies.Include(c => c.Genre).ToList();
			if (movieList.Count == 0)
			{
				return Content("Nothing found");
			}
			else
			{
				return View(movieList); 
			}
			
		}

		public ActionResult Details(int id)
		{
			var movieDetails = GetMovie().SingleOrDefault(c => c.Id == id);
			if (movieDetails == null)
			{
				return View(movieDetails);
			}
			else
			{
				return View(movieDetails);
			}
			
		}
		public IEnumerable<Movie> GetMovie()
		{
			var movieList = _context.Movies.Include(c => c.Genre).ToList();
			return (movieList);
		}

		public ActionResult MovieForm()
		{
			var genreList = _context.Genres.ToList();
			var movieFormViewModel=new MovieFormViewModel
			{
				Genres = genreList
			};
			return View(movieFormViewModel);
		}
		
		
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Save(Movie movie)
		{
			ModelState.Remove("Movie.Id");
			if (ModelState.IsValid)
			{
				if (movie.Id == 0)
				{
					_context.Movies.Add(movie);
				}
				else
				{
					var movieInDb = _context.Movies.Single(c => c.Id == movie.Id);
					movieInDb.MovieName = movie.MovieName;
					movieInDb.GenreId = movie.GenreId;
					movieInDb.ReleaseDate = movie.ReleaseDate;
					movieInDb.DateAdded = movie.DateAdded;
					movieInDb.StockAvailable = movie.StockAvailable;
				}

				_context.SaveChanges();
				return RedirectToAction("Index", "Movie");

			}
			else
			{
				var viewModel = new MovieFormViewModel
				{
					Movie = movie,
					Genres = _context.Genres.ToList()
				};
				return View("MovieForm", viewModel);
			}
		}
		public ActionResult Edit(int id)
		{
			var movie = _context.Movies.SingleOrDefault(c => c.Id == id);
			if (movie == null)
			{
				return HttpNotFound();
			}
			var viewModel = new MovieFormViewModel
			{
				Movie = movie,
				Genres = _context.Genres.ToList()
			};
			return View("MovieForm", viewModel);
		}
	}
}