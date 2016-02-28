using System;
using Arvelia.EF7.Sqlite.Repo;

namespace kz2.Models
{
	public class Post : IEntity
	{
		public int Id {get;set;}
		public string Content {get;set;}
		public DateTime Published {get;set;}
        public Subject Subject {get;set;}
	}
}