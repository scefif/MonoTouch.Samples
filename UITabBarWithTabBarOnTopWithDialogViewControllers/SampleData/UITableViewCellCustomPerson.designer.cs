// WARNING
//
// This file has been generated automatically by MonoDevelop to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace UITabBarWithTabBarOnTopWithDialogViewControllers.SampleUsages
{
	[Register ("UITableViewCellCustomPerson")]
	partial class UITableViewCellCustomPerson
	{
		[Outlet]
		MonoTouch.UIKit.UILabel labelNameLast { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel labelNameFirst { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel labelDateOfBirth { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton buttonTerminate { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (labelNameLast != null) {
				labelNameLast.Dispose ();
				labelNameLast = null;
			}

			if (labelNameFirst != null) {
				labelNameFirst.Dispose ();
				labelNameFirst = null;
			}

			if (labelDateOfBirth != null) {
				labelDateOfBirth.Dispose ();
				labelDateOfBirth = null;
			}

			if (buttonTerminate != null) {
				buttonTerminate.Dispose ();
				buttonTerminate = null;
			}
		}
	}
}
