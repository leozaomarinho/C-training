﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExeEnumCompo.Entities.Enums;

namespace ExeEnumCompo.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus OrderStatus { get; set; }
    }
}
