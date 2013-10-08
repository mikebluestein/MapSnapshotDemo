using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.MapKit;
using MonoTouch.CoreLocation;

namespace MapSnapshotDemo
{
	public partial class MapSnapshotDemoViewController : UIViewController
	{
		public MapSnapshotDemoViewController () : base ("MapSnapshotDemoViewController", null)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			var coord = new CLLocationCoordinate2D(42.346751, -71.096946);
			map.SetCenterCoordinate (coord, false);
			var region = MKCoordinateRegion.FromDistance (coord, 500, 500);

			snapshot.TouchUpInside += (sender, e) => {

				var options = new MKMapSnapshotOptions {
					Size = mapImageView.Bounds.Size,
					Region = region,
					MapType = MKMapType.Hybrid
				};

				var snapper = new MKMapSnapshotter (options);

				snapper.Start ((snap, err) => {
					if (err == null) {
						mapImageView.Image = snap.Image;
					}
				});
			};
		}
	}
}

