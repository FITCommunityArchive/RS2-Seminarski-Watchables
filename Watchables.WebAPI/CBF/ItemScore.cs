﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Watchables.WebAPI.CBF
{
    public class ItemScore<T>
    {
        public T Item { get; set; }
        public double Score { get; set; }
    }
}
