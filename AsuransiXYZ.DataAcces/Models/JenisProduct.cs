using System;
using System.Collections.Generic;

namespace AsuransiXYZ.DataAcces.Models;

public partial class JenisProduct
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
