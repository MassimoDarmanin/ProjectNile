using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Contracts.Movies
{
	public interface IMovieGrainClient
	{
		Task<MovieDataModel> Get(string id);

		Task Set(string key, string name);
	}
}
