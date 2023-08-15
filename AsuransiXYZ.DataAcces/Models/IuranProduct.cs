using System;
using System.Collections.Generic;

namespace AsuransiXYZ.DataAcces.Models;

public partial class IuranProduct
{
    public int Id { get; set; }

    public decimal? UnderTwenty { get; set; }

    public decimal? OverTwenty { get; set; }

    public decimal? Kendaraan { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
