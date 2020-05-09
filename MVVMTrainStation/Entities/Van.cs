using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    [Serializable]
    public class Van : IEntity
    {
        public int Id { get; set; }

        public ICollection<Seat> SeatList { get; set; }

        public string Class { get; set; }

        public int Number { get; set; }
    }

   
}
