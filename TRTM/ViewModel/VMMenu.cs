using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media;
using TRTM.Commands;
//using TRTM.Models;
using TRTM.Views;

namespace TRTM.ViewModels
{
    public class VMMenu : ViewModelBase
    {
        public VMMenu()
        {
        }
        public ViewModelBase CurrentViewModel { get; set; }
        private MyCommand? _CommandSwitchingViews;
        public MyCommand CommandSwitchingViews
        {
            get => _CommandSwitchingViews ??= new MyCommand(ExecuteSwitchingViews, () => true);
        }

        private void ExecuteSwitchingViews(object parameter)
        {
            switch(parameter)
            {
                case "A":
                    break;
                case "B":
                    break;
                case "C":
                    break;
                case "H":
                    break;
            }
        }
    }
}
