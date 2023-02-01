using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TNI2013110040
{	
	public partial class EventPage01 : ContentPage
	{	
		public EventPage01 ()
		{
			InitializeComponent ();
            openEV2.Clicked += OpenEV2_Clicked;
            openTap.Clicked += OpenTap_Clicked;
		}

        

        async private void OpenEV2_Clicked(object sender, EventArgs e)
        {
			await Navigation.PushModalAsync(new EventPage02());
        }

        async private void OpenTap_Clicked(object sender, EventArgs e)
        {
            var tp = new TabbedPage();
            tp.Children.Add(new EventPage03());
            tp.Children.Add(new LoginPage());
            tp.Children.Add(new CalculatorPage());
            await Navigation.PushAsync(tp);
        }
    }
}

