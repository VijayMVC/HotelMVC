﻿using System.Collections.Generic;

namespace HotelMVC.ViewModels
{
    public class ReservationViewModel
    {
        public string ArrivalDate { get; set; }
        public string DepartureDate { get; set; }
        public string RoomName { get; set; }
        public List<string> AmenityNames { get; set; }
    }
}