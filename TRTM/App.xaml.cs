using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using TRTM.ViewModels;
using TRTM.Views;

namespace TRTM
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        //ViewModels
        private readonly VMMenu _VmMenu;
        private readonly VMInventory _VMInventory;
        private readonly VMSearch _VMSearch;
        private readonly VMSelectObject _VMSelectObject;
        
        //Views
        private readonly Menu _MenuForm;
        private readonly VInventory _VInventoryForm;
        private readonly VSearch _VSearchForm;
        private readonly VSelectObject _VSelectObjectForm;


        public App()
        {
            //Init ViewModels
            _VmMenu = new VMMenu();
            _VMInventory = new VMInventory();
            _VMSearch = new VMSearch();
            _VMSelectObject = new VMSelectObject();
            
            //Init Views
            _MenuForm = new Menu(_VmMenu);
            _VInventoryForm = new VInventory(_VMInventory);
            _VSearchForm = new VSearch(_VMSearch);
            _VSelectObjectForm = new VSelectObject(_VMSelectObject);
            
            //init initial View
            _MenuForm.Show();
        }
    }
}
