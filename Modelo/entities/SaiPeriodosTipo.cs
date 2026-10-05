using System;
using System.Collections.Generic;

namespace test;

public partial class SaiPeriodosTipo
{
    public int TipoPeriodo { get; set; }

    public string? Descripcion { get; set; }

    public string? Codigo { get; set; }

    public virtual ICollection<SgaPeriodo> SgaPeriodos { get; set; } = new List<SgaPeriodo>();
}
