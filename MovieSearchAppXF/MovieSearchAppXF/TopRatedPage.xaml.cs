using System;
using System.Collections.Generic;
using MovieSearchAppXF.Services;
using Xamarin.Forms;

namespace MovieSearchAppXF
{
	public partial class TopRatedPage : ContentPage
	{
		private ApiService _apiService = new ApiService();
		private List<Models.Movie> _movieList;

		private async void Listview_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			if (e.SelectedItem == null)
			{
				return;
			}

			await this.Navigation.PushAsync(new MovieDetailPage() { BindingContext = e.SelectedItem });
		}

		private async void loadData()
		{
			listview.ItemsSource = null;
			listview.IsVisible = false;
			myIndicator.IsRunning = true;
			myIndicator.IsVisible = true;
			this._movieList = await _apiService.getMovie(false, "");
			BindingContext = this._movieList;
			listview.ItemsSource = this._movieList;
			listview.IsVisible = true;
			myIndicator.IsVisible = false;
			myIndicator.IsRunning = false;
		}

		public TopRatedPage(List<Models.Movie> movieList) {
			InitializeComponent();

			this._movieList = movieList;

			loadData();

			listview.RefreshCommand = new Command(() =>
			{
				loadData();
				listview.IsRefreshing = false;
			});
		}
	}
}
