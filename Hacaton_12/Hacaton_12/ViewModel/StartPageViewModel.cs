﻿using Hacaton_12.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Hacaton_12.ViewModel
{
    internal class StartPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        StartPageListViewModel _lvm;
        public Picture Picture { get; private set; }

        #region ctor
        public StartPageViewModel()
        {
            Picture = new Picture();
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
                if (Picture.Name != value)
                {
                    Picture.Name = value;
                    OnPropertyChanged(nameof(Name));
                }
            }
        }

        private void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
        
    }
}
