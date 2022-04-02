﻿using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CustomerOrderSystem_ASPNET.Models
{
    public partial class Order
    {
        public int Id { get; set; }
        public int? RestaurantId { get; set; }
        public int? TableNumber { get; set; }
        public int? FoodId { get; set; }
        public int? IsActive { get; set; }

        [JsonIgnore]
        public virtual RefFood? Food { get; set; }

        [JsonIgnore]
        public virtual RefRestaurant? Restaurant { get; set; }
    }
}
