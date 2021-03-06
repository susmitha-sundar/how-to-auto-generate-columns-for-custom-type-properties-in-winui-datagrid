﻿using Microsoft.UI.Xaml.Data;
using Syncfusion.UI.Xaml.Core;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinUIDemoApp
{
    public class ViewModel : INotifyPropertyChanged
    {
        ObservableCollection<Employee> source;
        protected EmployeeInfoRespository repository;
        protected int Count = 30;

        public void RaisePropertyChanged(string propName)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public ViewModel()
            : base()
        {
            repository = new EmployeeInfoRespository();
            source = repository.GetEmployeesDetails(Count);

        }

        public ObservableCollection<Employee> Source
        {
            get
            {
                return source;
            }
            set
            {
                source = value;
                RaisePropertyChanged("Source");
            }
        }
    }
}
