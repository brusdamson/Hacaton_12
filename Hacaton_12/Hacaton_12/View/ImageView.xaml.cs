using Hacaton_12.ViewModel;
using System.Threading.Tasks;
using Splat;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Drawing;

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
        public static bool IsDraw { get; set; } = false;
        #region touchEffect
        private void TouchEffect_TouchAction(object sender, TouchTracking.TouchActionEventArgs args)
        {

            if (ViewModel.Picture.Name == "One.png")
            {
                ViewModel.Name = "One2.png";
            }
            else if (ViewModel.Picture.Name == "bart.png")
            {
                ViewModel.Name = "Bart22.png";
            }
            else if (ViewModel.Picture.Name == "bear.png")
            {
                ViewModel.Name = "bear2.png";
            }
            else if (ViewModel.Picture.Name == "horse.png")
            {
                ViewModel.Name = "horse2.png";
            }
            else if (ViewModel.Picture.Name == "Olenb.png")
            {
                ViewModel.Name = "Olenb22.png";
            }
            else if (ViewModel.Picture.Name == "lion.png")
            {
                ViewModel.Name = "lion2.png";
            }
        }
        #endregion
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
        public static Xamarin.Forms.Color CurrentColor { get; set; }

        private async void ImageButton_Clicked(object sender, System.EventArgs e)
        {
           await Navigation.PopModalAsync();
        }
    }
    class UserAction
    {
        public Point point;
        public Xamarin.Forms.Color color;

        public UserAction(Point point, Xamarin.Forms.Color color)
        {
            this.point = point;
            this.color = color;
        }
    }

    class Point
    {
        public float x;
        public float y;

        public Point(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
    }
}