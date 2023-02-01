using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TNI2013110040
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            sendButton.Clicked += SendButton_Clicked;
            entryLabel.TextChanged += EntryLabel_TextChanged;
            slideLabel.ValueChanged += SlideLabel_ValueChanged;
            stepperTxt.ValueChanged += StepperTxt_ValueChanged;
            openSwitch.Toggled += OpenSwitch_Toggled;
            colorPick.SelectedIndexChanged += ColorPick_SelectedIndexChanged;
        }

        private void ColorPick_SelectedIndexChanged(object sender, EventArgs e)
        {
            textLabel5.Text = colorPick.SelectedItem.ToString();
        }

        private void OpenSwitch_Toggled(object sender, ToggledEventArgs e)
        {
            textLabel4.Text = (e.Value == true) ? "ON" : "OFF";
        }

        private void StepperTxt_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            textLabel3.Text = e.NewValue.ToString();
        }

        private void EntryLabel_TextChanged(object sender, TextChangedEventArgs e)
        {
            textLabel1.Text = entryLabel.Text;
        }

        private void SlideLabel_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            textLabel.Text = e.NewValue.ToString("N0");

        }

        private void SendButton_Clicked(object sender, EventArgs e)
        {
            textLabel2.Text = entryLabel.Text;
        }
    }
}

