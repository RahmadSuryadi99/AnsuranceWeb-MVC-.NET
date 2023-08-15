using System;
using System.Collections.Generic;

namespace AsuransiXYZ.DataAcces.Models;

public partial class KetentuanProduct
{
    public int Id { get; set; }

    public string Description { get; set; } = null!;

    public bool NasabahOnly { get; set; }

    public bool NasabahAndFamiliy { get; set; }

    public bool Kendaraan { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
