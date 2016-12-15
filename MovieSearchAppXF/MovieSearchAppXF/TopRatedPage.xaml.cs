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

		protected override async void OnAppearing()
		{
			base.OnAppearing();
			myIndicator.IsRunning = true;
			this._movieList = await _apiService.getMovie(false, "");
			myIndicator.IsRunning = false;
			myIndicator.IsVisible = false;
			await this.Navigation.PushAsync(new MovieListPage() { BindingContext = this._movieList });
		}

		public TopRatedPage(List<Models.Movie> movieList) {
			InitializeComponent();
			this._movieList = movieList;
		}

	}
}
