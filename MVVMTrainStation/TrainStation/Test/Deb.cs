using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TrainStation.Test
{
    public static class Deb
    {
        public static void Print(object data, string comment = " ")
        {
            Console.WriteLine($"{comment} {JsonConvert.SerializeObject(data)}");
        }
    }
}
