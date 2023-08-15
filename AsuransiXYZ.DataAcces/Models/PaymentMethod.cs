using System;
using System.Collections.Generic;

namespace AsuransiXYZ.DataAcces.Models;

public partial class PaymentMethod
{
    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public virtual ICollection<Nasabah> Nasabahs { get; set; } = new List<Nasabah>();
}
