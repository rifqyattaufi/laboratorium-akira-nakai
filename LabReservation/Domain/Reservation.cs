using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabReservation.Domain
{
    public class Reservation
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int LabId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Status { get; set; } // pending, approved, rejected
    }
}
