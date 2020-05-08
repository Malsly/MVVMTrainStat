using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    [Serializable]
    public class ClassAndPrice : IEntity
    {
        public string ClassName { get; set; }
        public int Price { get; set; }
        public int Id { get; set; }
    }
}
