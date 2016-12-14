using System.Collections.Generic;
using Xamarin.Forms;

namespace MovieSearchAppXF
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			var searchPage = new SearchPage(new List<Models.Movie>());
			var searchNavigationPage = new NavigationPage(searchPage);
			searchNavigationPage.Title = "Search";

			var topRatedPage = new TopRatedPage();
			var topRatedNavigationPage = new NavigationPage(topRatedPage);
			topRatedNavigationPage.Title = "Top Rated";

			var popularPage = new PopularPage();
			var popularNavigationPage = new NavigationPage(popularPage);
			popularNavigationPage.Title = "Popular";

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
