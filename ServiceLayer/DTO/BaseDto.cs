﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.DTO
{
    public abstract class BaseDto
    {
        public int ID { get; set; }
        public DateTime OlusturmaTarihi { get; set; }
    }
}
