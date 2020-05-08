
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainStation.Model
{
    public class StationModel 
    {
        private string stationName;

        public string StationName
        {
            get
            {
                return stationName;
            }
        }

        public StationModel(string stationName)
        {
            this.stationName = stationName;
        }

        public TicketModel GetTicket(PassangerModel passanger, TrainModel PickedTrain, VanModel PickedVan, SeatModel PickedSeat, string PlaceArrival)
        {
            int price = 46;
            return new TicketModel(passanger, price, PickedVan, PickedTrain, PickedSeat, PlaceArrival);
        }
    }
}
