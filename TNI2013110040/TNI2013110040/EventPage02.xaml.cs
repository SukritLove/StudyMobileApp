using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TNI2013110040
{	
	public partial class EventPage02 : ContentPage
	{	
		public EventPage02 ()
		{
			InitializeComponent ();
            closePage.Clicked += ClosePage_Clicked;
		}

		async private void ClosePage_Clicked(object sender, EventArgs e)
		{
			await Navigation.PopModalAsync();
		}
    }
}

