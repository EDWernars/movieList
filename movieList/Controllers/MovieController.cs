using movieList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace movieList.Controllers
{
	public class MovieController : Controller
	{
		IList<Actor> actors = new List<Actor>();
		IList<Movie> movies = new List<Movie>();

		public void FillActorsAndMovies()
		{
			// Add actors
			actors.Add(new Actor(1, "Robert"));
			actors.Add(new Actor(2, "Hans"));
			actors.Add(new Actor(3, "Dylan"));
			actors.Add(new Actor(4, "Fenna"));
			actors.Add(new Actor(5, "Sven"));
			actors.Add(new Actor(6, "Sarah"));
			actors.Add(new Actor(7, "Joep"));

			// Add movies
			movies.Add(new Movie(1, "Blade Runner 2049", "Dit is de beschrijving van Blade Runner", 163,
				actors.Where(x => x.ID == 1 || x.ID == 3 || x.ID == 6).ToList()));
			movies.Add(new Movie(2, "The Square", "Dit is de beschrijving van The Square", 142,
				actors.Where(x => x.ID == 1 || x.ID == 2 || x.ID == 4 || x.ID == 5 || x.ID == 7).ToList()));
			movies.Add(new Movie(3, "Paddington 2", "Dit is de beschrijving van Paddington 2", 103,
				actors.Where(x => x.ID == 1 || x.ID == 2 || x.ID == 3).ToList()));
			movies.Add(new Movie(4, "It", "Dit is de beschrijving van It", 135,
				actors.Where(x => x.ID == 3 || x.ID == 4 || x.ID == 5 || x.ID == 6 || x.ID == 7).ToList()));
			movies.Add(new Movie(5, "The Lion King", "Dit is de beschrijving van The Lion King", 89,
				actors.Where(x => x.ID == 1 || x.ID == 2 || x.ID == 6 || x.ID == 7).ToList()));
		}
		// GET: Movies
		public ActionResult Index(string search)
		{
			FillActorsAndMovies();
			// Check if the search field contains something.
			if (search != null)
			// Return a list with movies that contains the letters of the search fields without case sensitive.
				return View(movies.Where(x => x.Title.StartsWith(search, StringComparison.InvariantCultureIgnoreCase)).ToList());
			else
			// Return a list of all the movies to the view.
				return View(movies);
		}
		// GET: Movie
		public ActionResult Details(int id)
		{
			FillActorsAndMovies();
			// Search for the movie object.
			Movie movie = movies.Where(x => x.ID == id).First();

			// Return the object to the view.
			return View(movie);
		}
		// GET: Movie
		public ActionResult Favorites()
		{
			return View();
		}
	}
}