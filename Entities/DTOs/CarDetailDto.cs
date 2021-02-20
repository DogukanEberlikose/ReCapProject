﻿using System;
using System.Collections.Generic;
using System.Text;
using Core;
using Core.Entities;

namespace Entities.DTOs
{
    public class CarDetailDto : IDto
    {
        public int CarId { get; set; }
        public string BrandName { get; set; }
        public string ModelYear { get; set; }
        public string ColorName { get; set; } //Birleştiremedim
        public string Description { get; set; }
        public decimal DailyPrice { get; set; }

    }
}