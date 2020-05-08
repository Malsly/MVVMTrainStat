using TrainStation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainStation.ViewModel
{
    class VanViewModel
    {
        public StationViewModel Station
        {
            get;
            set;
        }
        private List<VanModel> vans;
        public string SelectedVanNumber
        {
            get;
            set;
        }
        public List<VanModel> Vans 
        {
            get { return vans; }
            set { vans = value; }
        }
        public void loadVanClasses() 
        {
            VanModel.AddClassAndPrice("Plackart", 0);
            VanModel.AddClassAndPrice("Cupe", 20);
        }
        public List<VanModel> loadVans(TrainModel selectedTrain)
        {
            Vans = selectedTrain.VanList;
            return vans;
        }
    }

}
