using Movies.Core;
using Orleans;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Movies.Contracts.Movies //
{
	public interface IMovieGrain : IGrainWithStringKey, IAppGrainContract
	{
		Task<MovieDataModel> Get();
	}

}
