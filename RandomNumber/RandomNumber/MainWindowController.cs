using System;
using System.Collections.Generic;
using System.Linq;
using MonoMac.Foundation;
using MonoMac.AppKit;

namespace RandomNumber
{
	public partial class MainWindowController : MonoMac.AppKit.NSWindowController
	{
		#region Constructors
		// Called when created from unmanaged code
		public MainWindowController (IntPtr handle) : base (handle)
		{
			Initialize ();
		}
		// Called when created directly from a XIB file
		[Export ("initWithCoder:")]
		public MainWindowController (NSCoder coder) : base (coder)
		{
			Initialize ();
		}
		// Call to load from the XIB/NIB file
		public MainWindowController () : base ("MainWindow")
		{
			Initialize ();
		}
		// Shared initialization code
		void Initialize ()
		{
		}
		#endregion
		//strongly typed window accessor
		public new MainWindow Window {
			get {
				return (MainWindow)base.Window;
			}
		}

		//Called when the Window is loaded
		public override void AwakeFromNib()
		{
			base.AwakeFromNib ();

			//Lets make the label empty. 
			lblRandomNumber.StringValue = ""; 
		}

		partial void btnGenerateRandomNumberClicked(NSObject sender)
		{
			var rnd = new System.Random ();
			lblRandomNumber.StringValue = Convert.ToString (rnd.Next ());
		}
	}
}

