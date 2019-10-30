﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab11_mvc_and_core.Models
{
    public class TimeSelected
    {
        public int FromYear { get; set; }
        public int ToYear { get; set; }

        public TimeSelected(int fromYear, int toYear)
        {
            FromYear = fromYear;
            ToYear = toYear;
        }
        public TimeSelected()
        {

        }
    }
}