using System;
using System.Collections.Generic;

namespace test;

public partial class SaiTramitesAdicionale
{
    public int Tramite { get; set; }

    public string Codigo { get; set; } = null!;

    public string? Descripcion { get; set; }

    public decimal? Importe { get; set; }

    public virtual SgaConstancia TramiteNavigation { get; set; } = null!;
}
