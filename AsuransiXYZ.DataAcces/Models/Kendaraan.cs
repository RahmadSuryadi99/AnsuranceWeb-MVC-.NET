using System;
using System.Collections.Generic;

namespace AsuransiXYZ.DataAcces.Models;

public partial class Kendaraan
{
    public int Id { get; set; }

    public string NoPolisi { get; set; } = null!;

    public string JenisKendaraan { get; set; } = null!;

    public string NoStnk { get; set; } = null!;

    public string Merek { get; set; } = null!;

    public string Model { get; set; } = null!;

    public string Warna { get; set; } = null!;

    public string IdNasabah { get; set; } = null!;

    public virtual Nasabah IdNasabahNavigation { get; set; } = null!;

    public virtual ICollection<PoliceAnsuransi> PoliceAnsuransis { get; set; } = new List<PoliceAnsuransi>();
}
