using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TNI2013110040
{
    public partial class App : Application
    {
        public App ()
        {
            InitializeComponent();
            // ประกาศเป็น var ได้เลยมันจะรู้ด้วยตัวมันเองว่าเป็นตัวแปรประเภทอะไร
            //-----------NavigationPage---------
            var page01 = new NavPage01();
            var np = new NavigationPage(page01);
            //MainPage = np;

            //-----------TebbedPage-------------
            var tp = new TabbedPage();
            tp.Children.Add(new TabPage01());
            tp.Children.Add(new TabPage02());
            tp.Children.Add(new TabPage03());
            //MainPage = tp;

            //-----------FlyoutPage-------------
            var fp = new FlyoutPage();
            fp.Flyout = new MenuPage();
            fp.Detail = new MainPage();
            //MainPage = fp;



            //---------------HW-----------------
            var eventP1 = new EventPage01();
            var navP = new NavigationPage(eventP1);
            MainPage = navP;
            //----------------------------------



            //MainPage = new NavPage01();

        }

        protected override void OnStart ()
        {
        }

        protected override void OnSleep ()
        {
        }

        protected override void OnResume ()
        {
        }
    }
}

