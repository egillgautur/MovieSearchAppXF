using System.Collections.Generic;
using Xamarin.Forms;

namespace MovieSearchAppXF
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			var content = new SearchPage(new List<Models.Movie>());
			MainPage = new NavigationPage(content);
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
