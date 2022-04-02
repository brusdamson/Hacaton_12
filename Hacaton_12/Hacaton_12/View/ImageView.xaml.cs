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
    }
}