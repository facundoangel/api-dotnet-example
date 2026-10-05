using System;
using System.Collections.Generic;

namespace test;

public partial class SgaLlamadosTurno
{
    public int Llamado { get; set; }

    public int Periodo { get; set; }

    public virtual SgaPeriodo PeriodoNavigation { get; set; } = null!;

    public virtual ICollection<SgaLlamadosMesa> SgaLlamadosMesas { get; set; } = new List<SgaLlamadosMesa>();
}
