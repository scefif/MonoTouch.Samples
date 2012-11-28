
using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.Collections.Generic;

namespace TEST
{
	public partial class CustomListCell 
		: UITableViewCell
	{  
		public CustomListCell () : base()
		{
		}
		
		public CustomListCell (IntPtr handle) : base(handle)
		{
		}

		// TODO: delegate
		public void UpdateData(string name, string timespan, bool delete)
		{
			lblName.Text = name;
			lblDate.Text = timespan;
			btnDelete.Hidden = false;	// (Mapping["delte"] == "true") ? true : false;

			// make View dirty
			this.SetNeedsDisplay();
		}


	}
}
