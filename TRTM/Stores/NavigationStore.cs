using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRTM.ViewModels;

namespace TRTM.Stores
{
    public class NavigationStore 
    {
        public ViewModelBase CurrentViewModel { get; set; }
    }
}
