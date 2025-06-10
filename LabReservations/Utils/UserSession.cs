using LabReservation.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabReservations.Utils
{
    public class UserSession
    {
        public User? User { get; set; }
        private static UserSession? _instance;
        public static UserSession Instance => _instance ??= new UserSession();
        private UserSession() { }
    }
}
