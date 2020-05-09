using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    [Serializable]
    public class Train : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string PlaceDeparture { get; set; }
        public string PlaceArrival { get; set; }
        
        public ICollection<Van> VanList { get; set; }
        public string Route { get; set; }
    }
}
