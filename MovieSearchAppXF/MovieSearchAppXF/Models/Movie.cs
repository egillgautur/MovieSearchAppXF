
namespace MovieSearchAppXF.Models
{
	public class Movie
	{

		public string Name { get; set; }

		public string ReleaseYear { get; set; }

		public string ImageName { get; set; }

		public string CastMembers { get; set; }

		public string Genre { get; set; }

		public string Runtime { get; set; }

		public string Overview { get; set; }

		public string InfoString { get; set; }

		public override string ToString()
		{
			return this.Name + " " + this.ReleaseYear;
		}
	}
}