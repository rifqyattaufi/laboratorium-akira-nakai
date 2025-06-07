using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabReservation.Utils
{
    public static class TimeValidator
    {
        public static bool IsValidReservationTime(DateTime start, DateTime end)
        {
            if (start.Date != end.Date) return false;
            var startHour = start.Hour;
            var endHour = end.Hour;
            return startHour >= 7 && endHour <= 18 && start < end;
        }
    }
}
