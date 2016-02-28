using System.Collections.Generic;
using Arvelia.EF7.Sqlite.Repo;

namespace kz2.Models
{
	public class Subject : IEntity
	{
		public int Id {get;set;}
		public string Title {get;set;}
		public List<Post> Posts {get;set;}
	}
}