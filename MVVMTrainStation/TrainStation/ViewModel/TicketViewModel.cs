using TrainStation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainStation.ViewModel
{
    class TicketViewModel
    {
        public StationViewModel Station
        {
            get;
            set;
        }
        private int price { get; set; }
        private string placeArrival { get; set; }
        public PassangerModel Passanger
        {
            get { return Station.Passanger; }   // get method
        }
        public string GetPrice()
        {
            int vanPrice;
            int seatPrice;
            int trainPrice;
            Train.RouteAndPrice.TryGetValue(Train.PlaceArrival, out trainPrice);
            VanModel.ClassAndPrice.TryGetValue(Van.Class, out vanPrice);
            SeatModel.TypeAndPrice.TryGetValue(Seat.Type, out seatPrice);
            int res = vanPrice + seatPrice + trainPrice;
            return res.ToString();
        }
        public string Price 
        {
            get { return GetPrice(); }
            set { }
        }
        public VanModel Van
        {
            get { return Station.SelectedVan; }   // get method
            set { }
        }
        public TrainModel Train
        {
            get { return Station.SelectedTrain; }   // get method
            set { }
        }
        public SeatModel Seat
        {
            get { return Station.SelectedSeat; }   // get method
            set { }
        }
        public string PlaceArrival
        {
            get { return placeArrival; }   // get method
            set { }
        }
        public string PlaceDeparture
        {
            get { return Train.PlaceDeparture; }   // get method
            set { }
        }
        public string PassangerName
        {
            get { return Passanger.Name; }   // get method
            set {  }
        }
        public string TrainName
        {
            get { return Train.Name; }   // get method
            set { }
        }
        public string VanNumber
        {
            get { return Van.Number.ToString(); }   // get method
            set { }
        }
        public string SeatNumber
        {
            get { return Seat.Number.ToString(); }   // get method
            set { }
        }
        public string TimeArriving
        {
            get { return Train.RouteAndDate[Train.PlaceArrival].ToString(); }   // get method
            set { }
        }

        public string TimeDeparture
        {
            get { return Train.RouteAndDate[PlaceDeparture].ToString(); }   // get method
            set { }
        }
    }
}
