using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace movieList.Models
{
	public class Actor
	{
		public int ID { get; set; }
		public string Name { get; set; }

		public Actor(int id, string name){
			ID = id;
			Name = name;
		}
	}
}