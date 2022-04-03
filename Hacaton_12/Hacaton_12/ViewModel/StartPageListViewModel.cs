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
    public class StartPageListViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public ObservableCollection<StartPageViewModel> Pictures { get; set; }

        #region cmd
        public ICommand OpenPictureCommand { get; protected set; }
        public ICommand SaveCommand { get; protected set; }
        public ICommand BackCommand { get; protected set; }
        
        #endregion
        StartPageViewModel selectedImage;
        public StartPageListViewModel()
        {
            Pictures = new ObservableCollection<StartPageViewModel>
            {
                new StartPageViewModel() { Id = 1, Name = "Bart.png" },
                new StartPageViewModel() { Id = 2, Name = "Bart2.png" },
                new StartPageViewModel() { Id = 3, Name = "bear.png" },
                new StartPageViewModel() { Id = 4, Name = "horse.png" },
                new StartPageViewModel() { Id = 5, Name = "lion.png" },
                new StartPageViewModel() { Id = 6, Name = "Olenb.png" },
                new StartPageViewModel() { Id = 7, Name = "Olenb2.png" },
                new StartPageViewModel() { Id = 8, Name = "One.png" }
            };

            OpenPictureCommand = new Command<StartPageViewModel>(OpenPicture);
            
            
            
            //SaveCommand = new Command(SavePicture);
            //BackCommand = new Command(Back);
        }
        private CollectionView collectionView;
        public CollectionView CollectionView
        {
            get
            {
                return collectionView;
            }
            set
            {
                collectionView = value;
                OnPropertyChanged(nameof(CollectionView));
            }
        }
        private async void OpenPicture(StartPageViewModel startPageViewModel)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new ImageView(startPageViewModel));
        }

        public StartPageViewModel SelectedImage
        {
            get { return selectedImage; }
            set
            {
                if (selectedImage != value)
                {
                    StartPageViewModel tempView = value;
                    selectedImage = null;
                    OnPropertyChanged(nameof(SelectedImage));
                    Application.Current.MainPage.Navigation.PushAsync(new ImageView(tempView));
                }
            }
        }
        protected void OnPropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}
