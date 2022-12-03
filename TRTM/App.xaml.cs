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
        private VMMenu _VmMenu;
        private VMInventory _VMInventory;
        private VMSearch _VMSearch;
        private VMSelectObject _VMSelectObject;
        
        //Views
        private Menu _MenuForm;
        private VInventory _VInventoryForm;
        private VSearch _VSearchForm;
        private VSelectObject _VSelectObjectForm;


        protected override void OnStartup(StartupEventArgs e)
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
            base.OnStartup(e);
        }
    }
}
