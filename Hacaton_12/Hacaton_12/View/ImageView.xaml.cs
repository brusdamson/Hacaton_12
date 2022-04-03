using Hacaton_12.ViewModel;
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
    public partial class ImageView : ContentPage
    {
        public StartPageViewModel ViewModel { get; private set; }
        public ImageView(StartPageViewModel vm)
        {
            InitializeComponent();
            ViewModel = vm;
            BindingContext = ViewModel;

        }
        private bool IsDraw { get; set; }   
        private int Taps { get; set; }
        private double PinchScale { get; set; }
        private void TouchEffect_TouchAction(object sender, TouchTracking.TouchActionEventArgs args)
        {
            
            
        }
        private async void StartTimer()
        {
            for (int i = 0; i < 1; i++)
            {
                await Task.Delay(1000);
            }
            IsPinched = false;
        }
        private bool IsPinched { get; set; }

        private void PinchGestureRecognizer_PinchUpdated(object sender, PinchGestureUpdatedEventArgs e)
        {
            IsPinched = true;
            StartTimer();
        }
    }
}