using System;
using System.Collections.Generic;

namespace AsuransiXYZ.DataAcces.Models;

public partial class Prospect
{
    public int IdProspect { get; set; }

    public string FirstName { get; set; } = null!;

    public string? LastName { get; set; }

    public DateTime BirthDate { get; set; }

    public string BirthPlace { get; set; } = null!;

    public string Gender { get; set; } = null!;

    public string? Pekerjaan { get; set; }

    public virtual Nasabah? Nasabah { get; set; }
}
