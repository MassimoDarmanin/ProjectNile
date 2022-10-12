using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Contracts.Movies
{
	public class MovieDataModel
	{
		protected string DebuggerDisplay => $"id: '{id}',key: '{key}',name: '{name}',description: '{description}', " +
			$"genres: '{genres}',rate: '{rate}',length: '{length}', img: '{img}'";

		public string id { get; set; }
		public string key { get; set; }
		public string name { get; set; }
		public string description { get; set; }
		public HashSet<string> genres { get; set; }
		public string rate { get; set; }
		public string length { get; set; }
		public string img { get; set; }

		public override string ToString() => DebuggerDisplay;
	}
}
