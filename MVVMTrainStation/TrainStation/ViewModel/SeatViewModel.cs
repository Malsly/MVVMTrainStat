using TrainStation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainStation.ViewModel
{
    class SeatViewModel
    {
        public StationViewModel Station
        {
            get;
            set;
        }
        private List<SeatModel> seats;
        public string SelectedSeatNumber
        {
            get;
            set;
        }
        public List<SeatModel> Seats
        {
            get { return seats; }
            set { seats = value; }
        }
        public void LoadSeatClasses()
        {
            SeatModel.AddTypeAndPrice("Main", 0);
            SeatModel.AddTypeAndPrice("Side", 0);
        }
        public List<SeatModel> loadSeats(VanModel selectedVan)
        {
            Seats = selectedVan.SeatList;
            return Seats;
        }
    }
}
