﻿using System;
using System.Collections.Generic;

namespace DB_First.Data.Models;

public partial class ProductsAboveAveragePrice
{
    public string ProductName { get; set; } = null!;

    public decimal? UnitPrice { get; set; }
}
