using TrainStation.Model;
using TrainStation.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainStation.ViewModel
{
    class TrainViewModel
    {


        public StationViewModel Station 
        {
            get;
            set;
        }

        public string SelectedPlaceArrival
        {
            get;
            set;
        }

        public string SelectedPlaceDeparture
        {
            get;
            set;
        }

        public string SelectedTrainName
        {
            get;
            set;
        }

        public List<TrainModel> TrainList
        {
            get;
            set;
        }

        public void getAccessedTrainList(string PlaceArrival, string PlaceDeparture) 
        {
            TrainList = Station.TrainList;
            if (PlaceArrival != "" && PlaceDeparture != "")
            {
                TrainList = TrainList.FindAll((item) => item.PlaceDeparture == PlaceDeparture && item.RouteAndPrice.ContainsKey(PlaceArrival));
            }
            else if (PlaceArrival == "")
            {
                TrainList = TrainList.FindAll((item) => item.PlaceDeparture == PlaceDeparture);
            }
            else 
            {
                TrainList = TrainList.FindAll((item) => item.PlaceDeparture == PlaceDeparture && item.RouteAndPrice.ContainsKey(PlaceArrival));
            }
        }


        public void getTrainList()
        {
            TrainList = Station.TrainList;
        }

    }
}
