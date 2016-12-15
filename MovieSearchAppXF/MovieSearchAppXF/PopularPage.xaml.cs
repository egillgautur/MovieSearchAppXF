using System;
using System.Collections.Generic;
using MovieSearchAppXF.Services;
using Xamarin.Forms;

namespace MovieSearchAppXF
{
	public partial class PopularPage : ContentPage
	{
		private ApiService _apiService = new ApiService();
		private List<Models.Movie> _movieList;

		public PopularPage(List<Models.Movie> movieList)
		{
			InitializeComponent();


			this._movieList = movieList;
		}

		protected override async void OnAppearing()
		{
			base.OnAppearing();

			myIndicator.IsRunning = true;
			this._movieList = await _apiService.getMovie(false, "Popular");
			myIndicator.IsRunning = false;
			myIndicator.IsVisible = false;
			await this.Navigation.PushAsync(new MovieListPage() { BindingContext = this._movieList });
		}
	}
}
