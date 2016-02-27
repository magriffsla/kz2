using System.Collections.Generic;

namespace kz2.Models
{
	public class Subject
	{
		public int SubjectId {get;set;}
		public string Title {get;set;}
		public List<Post> Posts {get;set;}
	}
}