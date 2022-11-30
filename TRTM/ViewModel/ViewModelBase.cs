using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRTM.ViewModels
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public static void OnPropertyChanged([NotNull] ViewModelBase vm, string propertyName)
        {
            vm.PropertyChanged?.Invoke(vm, new PropertyChangedEventArgs(propertyName));
        }

        protected void OnPropertyChanged(string propertyName)
        {
            OnPropertyChanged(this, propertyName);
        }
    }
}
