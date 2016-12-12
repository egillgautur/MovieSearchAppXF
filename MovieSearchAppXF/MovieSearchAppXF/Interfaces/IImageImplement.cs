using System.Threading.Tasks;

namespace MovieSearchAppXF.Interfaces
{
	public interface IImageImplement
	{
		Task<string> getImage(string path);
	}
}
