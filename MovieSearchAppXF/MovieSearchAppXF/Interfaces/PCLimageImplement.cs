/*using System.Threading;
using System.Threading.Tasks;
using MovieSearchAppXF.Interfaces;
using System.IO;
using MovieDownload;

namespace MovieSearchAppXF
{
	public class PCLImageImplement : IImageImplement
	{
		private ImageDownloader _downloader;
		public PCLImageImplement()
		{

			_downloader = new ImageDownloader(new StorageClient());
		}

		public async Task<string> getImage(string path)
		{
			//Path for image
			var localPath = "";
			if (path != null)
			{
				//localPath = _downloader.LocalPathForFilename(path);
				var cancelToken = new CancellationToken();
				//if (!File.Exists(path))
				{
				//	await _downloader.DownloadImage(path, localPath, cancelToken);
				}
			}

			return localPath;
		}
	}
}*/