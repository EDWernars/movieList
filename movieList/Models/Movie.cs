using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace movieList.Models
{
	public class Movie
	{
		public int ID { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public int Duration { get; set; }
		public IList<Actor> Actors { get; set; }

		public Movie(int id, string title, string description, int duration, IList<Actor> actors){
			ID = id;
			Title = title;
			Description = description;
			Duration = duration;
			Actors = actors;
		}
	}
}