/*using Xamarin.Forms;

using XFHelloWorld.iOS.Renderers;

//Code from Hrafn
[assembly: ExportRenderer(typeof(ViewCell), typeof(CustomCellRenderer))]
namespace XFHelloWorld.iOS.Renderers
{
	using UIKit;
	using Xamarin.Forms.Platform.iOS;

	public class CustomCellRenderer : ViewCellRenderer
	{
		public override UITableViewCell GetCell(Cell item, UITableViewCell reusableCell, UITableView tv)
		{
			var cell = base.GetCell(item, reusableCell, tv);

			cell.SelectionStyle = UITableViewCellSelectionStyle.None;

			cell.Accessory = UITableViewCellAccessory.DisclosureIndicator;

			return cell;
		}
	}
}*/