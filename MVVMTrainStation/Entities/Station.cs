using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Entities
{
    [Serializable]
    public class Station : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Train> Trains { get; set; }
    }
}
