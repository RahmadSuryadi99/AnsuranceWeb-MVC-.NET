using System;
using System.Collections.Generic;

namespace AsuransiXYZ.DataAcces.Models;

public partial class Nasabah
{
    public string IdNasabah { get; set; } = null!;

    public string NoKtp { get; set; } = null!;

    public string StatusKk { get; set; } = null!;

    public string PaymentCode { get; set; } = null!;

    public int IdProspect { get; set; }

    public virtual Prospect IdProspectNavigation { get; set; } = null!;

    public virtual ICollection<Kendaraan> Kendaraans { get; set; } = new List<Kendaraan>();

    public virtual PaymentMethod PaymentCodeNavigation { get; set; } = null!;

    public virtual ICollection<PoliceAnsuransi> PoliceAnsuransiNasabahTertanggungNavigations { get; set; } = new List<PoliceAnsuransi>();

    public virtual ICollection<PoliceAnsuransi> PoliceAnsuransiPemilikNavigations { get; set; } = new List<PoliceAnsuransi>();
}
