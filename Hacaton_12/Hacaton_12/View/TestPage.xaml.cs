using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Hacaton_12.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TestPage : ContentPage
    {
        public TestPage()
        {
            InitializeComponent();
            Timer();
        }
        private int Counter { get; set; }
        private async void Timer()
        {
            while (true)
            {
                for (int i = 3; i > 0; i--)
                {
                    await Task.Delay(1000);
                    Counter = 0;
                }
            }
        }
        private async void TouchEffect_TouchAction(object sender, TouchTracking.TouchActionEventArgs args)
        {
            
            Counter++;
            if (Counter < 2)
            {
                await DisplayAlert("qwe",$"x:{args.Location.X} y:{args.Location.Y}","qwe");
            }
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
           
        }
    }
}