using System;

namespace kz2.Models
{
	public class Post
	{
		public int PostId {get;set;}
		public string Content {get;set;}
		public DateTime Published {get;set;}
        public Subject Subject {get;set;}
	}
}