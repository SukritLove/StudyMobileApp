using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TNI2013110040

{	
	public partial class CalculatorPage : ContentPage
	{	
		public CalculatorPage ()
		{
			InitializeComponent ();
            num0.Clicked += Num0_Clicked;
            num1.Clicked += Num1_Clicked;
            num2.Clicked += Num2_Clicked;
            num3.Clicked += Num3_Clicked;
            num4.Clicked += Num4_Clicked;
            num5.Clicked += Num5_Clicked;
            num6.Clicked += Num6_Clicked;
            num7.Clicked += Num7_Clicked;
            num8.Clicked += Num8_Clicked;
            num9.Clicked += Num9_Clicked;
            del.Clicked += Del_Clicked;
        }
        //Button
        private void Del_Clicked(object sender, EventArgs e)
        {
            screenShow.Text = "del";
        }

        private void Num9_Clicked(object sender, EventArgs e)
        {
            screenShow.Text = "9";
            Screen("9");
        }

        private void Num8_Clicked(object sender, EventArgs e)
        {
            screenShow.Text = "8";
            Screen("8");
        }

        private void Num7_Clicked(object sender, EventArgs e)
        {
            screenShow.Text = "7";
            Screen("7");
        }

        private void Num6_Clicked(object sender, EventArgs e)
        {
            screenShow.Text = "6";
            Screen("6");
        }

        private void Num5_Clicked(object sender, EventArgs e)
        {
            screenShow.Text = "5";
            Screen("5");
        }

        private void Num4_Clicked(object sender, EventArgs e)
        {
            screenShow.Text = "4";
            Screen("4");
        }

        private void Num3_Clicked(object sender, EventArgs e)
        {
            screenShow.Text = "3";
            Screen("3");
        }

        private void Num2_Clicked(object sender, EventArgs e)
        {
            screenShow.Text = "2";
            Screen("2");
        }

        private void Num1_Clicked(object sender, EventArgs e)
        {
            screenShow.Text = "1";
            Screen("1");
        }

        private void Num0_Clicked(object sender, EventArgs e)
        {
            screenShow.Text = "0";
            Screen("0");
        }
        //Button



        public void Screen(String a)
        {
            if (a.Equals("del")) {
                //screenShow.Text ;
            }
            else
            {
                screenShow.Text += a;
            }

        }
        
        public void Solution()
        {

        }

        


    }
}

