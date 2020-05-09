using Entities.Interfaces;
using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    [Serializable]
    public class Seat : IEntity
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public string Type { get; set; }
        public Boolean IsOccuped { get; set; }
    }
}
