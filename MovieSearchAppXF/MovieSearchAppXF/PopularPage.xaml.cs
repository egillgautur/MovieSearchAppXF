using System;
using System.Collections.Generic;
using DLToolkit.Forms.Controls;
using MovieSearchAppXF.Services;
using Xamarin.Forms;

namespace MovieSearchAppXF
{
	public partial class PopularPage : ContentPage
	{
		private ApiService _apiService = new ApiService();
		private List<Models.Movie> _movieList;

		private async void OnImageSelected(object sender, ItemTappedEventArgs e)
		{
			if (e.Item == null)
			{
				return;
			}

			await this.Navigation.PushAsync(new MovieDetailPage() { BindingContext = e.Item });
		}

		private async void loadData()
		{
			flowlistview.IsVisible = false;
			myIndicator.IsRunning = true;
			myIndicator.IsVisible = true;
			_movieList = await _apiService.getMovie(false, "Popular");
			BindingContext = this._movieList;
			flowlistview.IsVisible = true;
			myIndicator.IsVisible = false;
			myIndicator.IsRunning = false;
		}

		public PopularPage(List<Models.Movie> movieList)
		{
			InitializeComponent();

			this._movieList = movieList;

			loadData();

			flowlistview.RefreshCommand = new Command(() =>
			{
				loadData();
				flowlistview.IsRefreshing = false;
			});
		}
	}
}
