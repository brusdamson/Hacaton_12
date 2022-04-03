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
    public partial class ColorPickerPage : ContentPage
    {
        private StartPageViewModel model;
        public ColorPickerPage(StartPageViewModel spvm)
        {
            InitializeComponent();
            model = spvm;
        }

        private void colorPicker_SelectedColorChanged(object sender, ColorPicker.BaseClasses.ColorPickerEventArgs.ColorChangedEventArgs e)
        {
            model.Color = e.NewColor;
            model.OldColor = e.OldColor;

        }
    }
}