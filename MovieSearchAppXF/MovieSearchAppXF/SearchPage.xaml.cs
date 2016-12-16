using System;
using System.Collections.Generic;
using MovieSearchAppXF.Services;
using Xamarin.Forms;

namespace MovieSearchAppXF
{
	public partial class SearchPage : ContentPage
	{
		private List<Models.Movie> _movieList;
		private ApiService _apiService;

		public SearchPage(List<Models.Movie> movieList)
		{
			InitializeComponent();

			this._movieList = movieList;
			this._apiService = new ApiService();

			searchEntry.SearchCommand = new Command(() =>
			{
				OnSearchButtonClicked(null, null);
			});
		}

		private async void Listview_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			if (e.SelectedItem == null)
			{
				return;
			}

			((ListView)sender).SelectedItem = null;
			await this.Navigation.PushAsync(new MovieDetailPage() { BindingContext = e.SelectedItem });
		}

		private async void OnSearchButtonClicked(object sender, EventArgs args)
		{
			listview.ItemsSource = null;
			listview.IsVisible = false;
			indicator.IsRunning = true;
			indicator.IsVisible = true;
			this._movieList = await _apiService.getMovie(true, searchEntry.Text);
			BindingContext = this._movieList;
			listview.ItemsSource = this._movieList;
			indicator.IsRunning = false;
			indicator.IsVisible = false;
			listview.IsVisible = true;
		}

	}
}
