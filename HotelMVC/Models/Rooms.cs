﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HotelMVC.Models
{
    public class Rooms
    {
        public byte Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        public List<Amenities> Amenities { get; set; }
    }
}