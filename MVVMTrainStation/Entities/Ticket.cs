using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Entities
{
    [Serializable]
    public class Ticket : IEntity
    {
        public int Id { get; set; }
        public Passanger Passanger { get; set; }
        public int Price { get; set; }
        public Van VanId { get; set; }
        public Train TrainId { get; set; }
        public Seat SeatId { get; set; }
        public string PlaceArrival { get; set; }
        public Station Station { get; set; }

    }
}
