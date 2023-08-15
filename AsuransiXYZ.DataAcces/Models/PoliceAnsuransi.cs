using System;
using System.Collections.Generic;

namespace AsuransiXYZ.DataAcces.Models;

public partial class PoliceAnsuransi
{
    public int Id { get; set; }

    public string Pemilik { get; set; } = null!;

    public string? NasabahTertanggung { get; set; }

    public int? KendaraanTertanggung { get; set; }

    public DateTime StartDate { get; set; }

    public int ProductId { get; set; }

    public virtual Kendaraan? KendaraanTertanggungNavigation { get; set; }

    public virtual Nasabah? NasabahTertanggungNavigation { get; set; }

    public virtual Nasabah PemilikNavigation { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;
}
