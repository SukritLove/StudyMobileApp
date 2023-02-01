using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TNI2013110040
{	
	public partial class NavPage01 : ContentPage
	{
        //Navigation.PushAsync <-- เปิดหน้าใหม่ขึ้นมา(ทับหน้าเก่าคล้ายเปิดหนังสือ)
        //Navigation.PopAsync <-- ปิดหน้าเก่าและเปิดหน้าใหม่
        //Navigation.PushModalAsync <-- เปิดเปลี่ยนหน้าได้เหมือนหนังสือไม่มีปุ่มย้อนกลับให้ต้องกดย้อนกลับปกติเอง
        //Navigation.PopModalAsync <-- เปิดเหมือน Pop-up

        public NavPage01 ()
		{
			InitializeComponent ();

            openPage2.Clicked += OpenPage2_Clicked;
            openPage3.Clicked += OpenPage3_Clicked;
            youTube.Clicked += YouTube_Clicked;
		}

        async private void YouTube_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new YoutubePage());
        }

        async private void OpenPage3_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavPage03());
        }

        async private void OpenPage2_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavPage02());
        }
    }
}

