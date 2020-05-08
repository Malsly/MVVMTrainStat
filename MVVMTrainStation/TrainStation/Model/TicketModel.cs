
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainStation.Model
{
    public class TicketModel 
    {
        private PassangerModel passanger { get; set; }
        private int price { get; set; }
        private VanModel van { get; set; }
        private TrainModel train { get; set; }
        private SeatModel seat { get; set; }
        private string placeArrival { get; set; }

        public PassangerModel Passanger
        {
            get { return passanger; }   // get method
        }
        public int Price
        {
            get { return this.GetPrice(); }   // get method
        }
        public VanModel Van
        {
            get { return van; }   // get method
        }
        public TrainModel Train
        {
            get { return train; }   // get method
        }
        public SeatModel Seat
        {
            get { return seat; }   // get method
        }
        public string PlaceArrival
        {
            get { return placeArrival; }   // get method
        }

        public TicketModel(PassangerModel Passanger, int Price, VanModel Van, TrainModel Train, SeatModel Seat, string PlaceArrival)
        {
            this.passanger = Passanger;
            this.van = Van;
            this.train = Train;
            this.seat = Seat;
            this.placeArrival = PlaceArrival;
        }
        public int GetPrice()
        {
            int vanPrice;
            int seatPrice;
            int trainPrice;
            train.RouteAndPrice.TryGetValue(train.PlaceArrival, out trainPrice);
            VanModel.ClassAndPrice.TryGetValue(van.Class, out vanPrice);
            SeatModel.TypeAndPrice.TryGetValue(seat.Type, out seatPrice);
            return vanPrice + seatPrice + trainPrice;
        }
        public TicketModel SendToMail()
        {
            return this;
        }
    }
}
