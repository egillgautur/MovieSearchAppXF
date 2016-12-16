using System.Collections.Generic;
using Xamarin.Forms;

namespace MovieSearchAppXF
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			var searchPage = new SearchhPage(new List<Models.Movie>());
			var searchNavigationPage = new NavigationPage(searchPage) { 
				Icon = "search.png",
				Title = "Search"
			};

			var topRatedPage = new TopRatedPage(new List<Models.Movie>());
			var topRatedNavigationPage = new NavigationPage(topRatedPage) { 
				Icon = "toprated.png",
				Title = "Top Rated"
			};

			var popularPage = new PopularPage(new List<Models.Movie>());
			var popularNavigationPage = new NavigationPage(popularPage)
			{
				Icon = "popular.png",
				Title = "Most Popular",
			};

			var tabbedPage = new TabbedPage();
			tabbedPage.Children.Add(searchNavigationPage);
			tabbedPage.Children.Add(topRatedNavigationPage);
			tabbedPage.Children.Add(popularNavigationPage);

			this.MainPage = tabbedPage;
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
