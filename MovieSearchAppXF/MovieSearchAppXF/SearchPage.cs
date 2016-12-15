using System;
using System.Collections.Generic;
using MovieSearchAppXF.Services;
using Xamarin.Forms;

namespace MovieSearchAppXF
{
	public class SearchPage : ContentPage
	{
		private ApiService _apiService = new ApiService();
		private List<Models.Movie> _movieList;

		private ActivityIndicator _indicator = new ActivityIndicator
		{
			HorizontalOptions = LayoutOptions.CenterAndExpand,
			Color = Color.Gray
		};

		private Label _entryLabel = new Label
		{
			HorizontalOptions = LayoutOptions.Start,
			Text = "Enter a movie name:",
		};

		private Entry _searchEntry = new Entry
		{
			HorizontalOptions = LayoutOptions.Fill,
			Placeholder = "Movie..",
		};

		private Button _searchButton = new Button
		{
			Text = "Search",
			BorderColor = Color.Gray,
			HorizontalOptions = LayoutOptions.Fill,
		};

		private async void OnDisplayNameButtonClicked(object sender, EventArgs args)
		{

			this._indicator.IsRunning = true;
			this._searchButton.IsEnabled = false;
			this._movieList = await _apiService.getMovie(true, _searchEntry.Text);
			this._searchButton.IsEnabled = true;
			this._indicator.IsRunning = false;

			await this.Navigation.PushAsync(new MovieListPage() { BindingContext = this._movieList });
		}

		public SearchPage(List<Models.Movie> movieList)
		{
			this._movieList = movieList;
			this.BackgroundColor = Color.FromRgb(240, 240, 240);
			this.Title = "Movie Search App";

			this.Content = new StackLayout
			{
				Margin = 30,
				VerticalOptions = LayoutOptions.Start,
				Spacing = 10,
				Children =
									   {
										   new StackLayout { Children = { this._entryLabel, this._searchEntry, }, },
										   this._searchButton,
					this._indicator
									   }
			};

			this._searchButton.Clicked += this.OnDisplayNameButtonClicked;
			this._searchEntry.Completed += this.OnDisplayNameButtonClicked;
		}

	}
}