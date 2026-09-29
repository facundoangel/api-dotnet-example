using System;
using System.Collections.Generic;

namespace test.Models;

public partial class SaiComisionesAgrupadasDetalle
{
    public int ComisionAgrupada { get; set; }

    public int Comision { get; set; }

    public DateTime FechaDesde { get; set; }

    public DateTime? FechaHasta { get; set; }

    public virtual SaiComisionesAgrupada ComisionAgrupadaNavigation { get; set; } = null!;

    public virtual SgaComisione ComisionNavigation { get; set; } = null!;
}
