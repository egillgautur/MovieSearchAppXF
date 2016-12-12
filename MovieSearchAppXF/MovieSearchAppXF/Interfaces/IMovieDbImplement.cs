using DM.MovieApi;

namespace MovieSearchAppXF.Interfaces
{
	public class IMovieDbImplement : IMovieDbSettings
	{
		public IMovieDbImplement()
		{
		}

		public string ApiKey
		{
			get
			{
				return "dd8579f19de65afd440a381f5b4e8d8e";
			}
		}

		public string ApiUrl
		{
			get
			{
				return "http://api.themoviedb.org/3/";
			}
		}
	}
}