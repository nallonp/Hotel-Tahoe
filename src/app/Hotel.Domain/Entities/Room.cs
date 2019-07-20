﻿using Hotel.Domain.Base;
using Hotel.Domain.Entities.ValueObj;
using System;

namespace Hotel.Domain.Entities
{
    public class Room : Entity
    {
        public PricePolicy Prices { get; set; }
        public Boolean Occupied { get; set; }
        public Boolean Active { get; set; }
    }
}
