using Hacaton_12.Model;
using Hacaton_12.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Hacaton_12.ViewModel
{
    public class StartPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        StartPageListViewModel _lvm;
        public Picture Picture { get; private set; }

        #region cmd
        public ICommand OpenColorPicker { get; protected set; }
        public ICommand BackCommand { get; protected set; }
        public ICommand RefreshCommand { get; protected set; }
        public ICommand SaveCommand { get; protected set; }
        #endregion

        #region ctor
        public StartPageViewModel()
        {
            Picture = new Picture();
            OpenColorPicker = new Command(OpenColorPickerPage);
            BackCommand = new Command(Back);
            RefreshCommand = new Command(Refresh);
            SaveCommand = new Command(Save);
        }
        #endregion

        #region commandsImplementation
        private void Save(object obj)
        {
            Application.Current.MainPage.DisplayAlert("Сохранено", "Иллюстрация сохранена.", "Ок");
        }
        private void Refresh(object obj)
        {
            if (Name == "One2.png")
            {
                Name = "One.png";
            }
            else if (Name == "Bart22.png")
            {
                Name = "bart.png";
            }
            else if (Name == "bear2.png")
            {
                Name = "bear.png";
            }
            else if (Name == "horse2.png")
            {
                Name = "horse.png";
            }
            else if (Name == "Olenb22.png")
            {
                Name = "Olenb.png";
            }
            else if (Name == "lion2.png")
            {
                Name = "lion.png";
            }

        }
        #endregion

        public StartPageListViewModel ListViewModel
        {
            get { return _lvm; }
            set 
            {
                if (_lvm != value)
                {
                    _lvm = value;
                    OnPropertyChanged(nameof(ListViewModel));
                }
            }
        }
        private void Back(object obj)
        {
            Application.Current.MainPage.Navigation.PopAsync();
        }
        public int Id
        {
            get { return Picture.Id; }
            set
            {
                if (Picture.Id != value)
                {
                    Picture.Id = value;
                    OnPropertyChanged(nameof(Id));
                }
            }
        }
        public string Name
        {
            get { return Picture.Name; }
            set
            {
                if (Picture.Name == "One.png")
                {
                    ImageView.IsDraw = true;
                }
                if (Picture.Name != value)
                {
                    Picture.Name = value;
                    OnPropertyChanged(nameof(Name));
                }
            }
        }
        private Color oldColor;
        private Color color;
        public Color OldColor
        {
            get { return oldColor; }
            set
            {
                if (OldColor != value)
                {
                    oldColor = value;
                    OnPropertyChanged(nameof(OldColor));
                }
                else
                {
                    OldColor = Color.Black;
                    OnPropertyChanged(nameof(OldColor));
                }
            }
        }
        public Color Color
        {
            get { return color; }
            set
            {
                if (Color != value)
                {
                    color = value;
                    OnPropertyChanged(nameof(Color));
                }
                else
                {
                    color = Color.Red;
                    OnPropertyChanged(nameof(Color));
                }
            }
        }
        private void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
        private void OpenColorPickerPage()
        {
            Application.Current.MainPage.Navigation.PushModalAsync(new ColorPickerPage(this));
        }
    }
}
