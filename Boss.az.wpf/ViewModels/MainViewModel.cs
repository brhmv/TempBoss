using Boss.az.wpf.View;
using Boss.az.wpf.Views;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Boss.az.wpf.ViewModels
{
    internal class MainViewModel : ViewModelBase, INotifyPropertyChanged
    {

        public string? User { get; set; }
        public string? sss { get; set; }


        UserControl? _UC = new WorkerOrEmployer();

        public UserControl? CurrentViewModel
        {
            get { return _UC; }
            set { Set(ref _UC, value); }
        } 

        //private ViewModelBase _currentViewModel;
        //public ViewModelBase CurrentViewModel
        //{
        //    get { return _currentViewModel; }
        //    set
        //    {
        //        if (_currentViewModel != value)
        //        {
        //            _currentViewModel = value;
        //            OnPropertyChanged(nameof(CurrentViewModel));
        //        }
        //    }
        //}


        public MainViewModel()
        {
            sss = "sss";
        }


        
        public RelayCommand UserIsWorker
        {
            get => new RelayCommand(() =>
        {
            User = "Worker";
            MessageBox.Show("Worker");
            CurrentViewModel = new SignİnUp();         



            // UserControl = new SignInUp();

        });
        }

        public RelayCommand UserIsEmployer
        {
            get => new RelayCommand(() =>
            {
                User = "Employer";
                MessageBox.Show(User);
            });
        }
    }
}
