// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;
using System.CodeDom.Compiler;

namespace MapSnapshotDemo
{
	[Register ("MapSnapshotDemoViewController")]
	partial class MapSnapshotDemoViewController
	{
		[Outlet]
		MonoTouch.MapKit.MKMapView map { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIImageView mapImageView { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton snapshot { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (map != null) {
				map.Dispose ();
				map = null;
			}

			if (mapImageView != null) {
				mapImageView.Dispose ();
				mapImageView = null;
			}

			if (snapshot != null) {
				snapshot.Dispose ();
				snapshot = null;
			}
		}
	}
}
