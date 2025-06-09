using LabReservation.Domain;
using LabReservation.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabReservations.Forms
{
    public partial class DashboardUser: Form
    {
        private readonly LabService _labService = new LabService();
        private readonly ReservationService _reservationService = new ReservationService();
        private readonly UserService _userService;
        private User _currentUser;

        public DashboardUser(User currentUser)
        {
            InitializeComponent();
        }
    }
}
