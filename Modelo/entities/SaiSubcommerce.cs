using System;
using System.Collections.Generic;

namespace test;

public partial class SaiSubcommerce
{
    public int Subcommerce { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string? Descripcion { get; set; }

    public virtual ICollection<SgaResponsablesAcademica> ResponsableAcademicas { get; set; } = new List<SgaResponsablesAcademica>();
}
