using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabReservation.Utils
{
    public class Config
    {
        public int MaxReservationPerUser { get; set; }
        public static Config Load(string path = "Data/config.json")
        {
            return File.Exists(path)
                ? JsonSerializer.Deserialize<Config>(File.ReadAllText(path))!
                : new Config { MaxReservationPerUser = 3 };
        }
    }
}