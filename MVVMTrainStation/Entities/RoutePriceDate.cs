using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    [Serializable]
    public class RoutePriceDate : IEntity
    {
        public string RoutName { get; set; }
        public DateTime Date { get; set; }
        public int Price { get; set; }
        public int Id { get; set; }
    }
}
