using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TNI2013110040
{	
	public partial class EventPage03 : ContentPage
	{	
		public EventPage03 ()
		{
			InitializeComponent ();
            openEV2.Clicked += OpenEV2_Clicked;
		}

        async private void OpenEV2_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new EventPage02());
        }
    }
}

