using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    [Serializable]
    public class TypeAndPrice : IEntity
    {
        public int TypeName { get; set; }
        public int Price { get; set; }
        public int Id { get; set; }
    }
}
