using System;
using System.Collections.Generic;

namespace test;

public partial class SaiComisionesObservacione
{
    public int Comision { get; set; }

    public string Observacion { get; set; } = null!;

    public virtual SgaComisione ComisionNavigation { get; set; } = null!;
}
