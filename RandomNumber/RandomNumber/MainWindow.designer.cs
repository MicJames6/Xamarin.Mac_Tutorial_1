// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoMac.Foundation;
using System.CodeDom.Compiler;

namespace RandomNumber
{
	[Register ("MainWindowController")]
	partial class MainWindowController
	{
		[Outlet]
		MonoMac.AppKit.NSTextField lblRandomNumber { get; set; }

		[Action ("btnGenerateRandomNumberClicked:")]
		partial void btnGenerateRandomNumberClicked (MonoMac.Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (lblRandomNumber != null) {
				lblRandomNumber.Dispose ();
				lblRandomNumber = null;
			}
		}
	}

	[Register ("MainWindow")]
	partial class MainWindow
	{
		[Outlet]
		MonoMac.AppKit.NSTextField lblRandomNumber { get; set; }

		[Action ("btnGenerateRandomNumberClicked:")]
		partial void btnGenerateRandomNumberClicked (MonoMac.Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (lblRandomNumber != null) {
				lblRandomNumber.Dispose ();
				lblRandomNumber = null;
			}
		}
	}
}
