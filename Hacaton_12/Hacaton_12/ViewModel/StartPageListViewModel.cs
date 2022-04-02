using Hacaton_12.Model;
using Hacaton_12.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Hacaton_12.ViewModel
{
    internal class StartPageListViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public ObservableCollection<Picture> Pictures { get; set; }

        #region cmd
        public ICommand OpenPictureCommand { get; protected set; }
        public ICommand SaveCommand { get; protected set; }
        public ICommand BackCommand { get; protected set; }
        
        #endregion
        StartPageViewModel selectedImage;
        public StartPageListViewModel()
        {
            Pictures = new ObservableCollection<Picture>() { new Picture { Id = 1, Name = "fox.xml"} };
            OpenPictureCommand = new Command(OpenPicture);
            
            
            //SaveCommand = new Command(SavePicture);
            //BackCommand = new Command(Back);
        }

        
        private async void OpenPicture()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new ImageView());
        }

        StartPageViewModel SelectedImage
        {
            get { return selectedImage; }
            set
            {
                if (selectedImage != value)
                {
                    StartPageViewModel tempView = value;
                    selectedImage = null;
                    OnPropertyChanged(nameof(SelectedImage));
                    //Application.Current.MainPage.Navigation.PushAsync();
                }
            }
        }
        protected void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
    }
}
