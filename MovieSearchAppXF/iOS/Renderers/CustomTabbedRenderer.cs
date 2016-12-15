using System;
using MovieSearchAppXF.iOS.Renderers;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(TabbedPage), typeof(CustomTabbedRenderer))]
namespace MovieSearchAppXF.iOS.Renderers
{
	public class CustomTabbedRenderer : TabbedRenderer
	{
		public override void ViewWillAppear(bool animated)
		{
			base.ViewWillAppear(animated);
			var items = TabBar.Items;

			foreach (var t in items)
			{
				var txtFont = new UITextAttributes()
				{
					Font = UIFont.SystemFontOfSize(13)
				};

				t.SetTitleTextAttributes(txtFont, UIControlState.Normal);


			}


			//items[0].Image = UIImage.FromBundle("search.png");
			//items[1].Image = UIImage.FromBundle("toprated.png");
			//items[2].Image = UIImage.FromBundle("popular.png");
		}
	}
}
