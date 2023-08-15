using System;
using System.Collections.Generic;

namespace AsuransiXYZ.DataAcces.Models;

public partial class Product
{
    public int IdProduct { get; set; }

    public string Nama { get; set; } = null!;

    public string Frekuensi { get; set; } = null!;

    public string Manfaat { get; set; } = null!;

    public int Jenis { get; set; }

    public int IuranId { get; set; }

    public int KetentuanId { get; set; }

    public virtual IuranProduct Iuran { get; set; } = null!;

    public virtual JenisProduct JenisNavigation { get; set; } = null!;

    public virtual KetentuanProduct Ketentuan { get; set; } = null!;

    public virtual ICollection<PoliceAnsuransi> PoliceAnsuransis { get; set; } = new List<PoliceAnsuransi>();
}
