using System;
using System.Collections.Generic;

namespace test;

public partial class SgaElementosRevision
{
    public int ElementoRevision { get; set; }

    public int Elemento { get; set; }

    public virtual SgaElemento ElementoNavigation { get; set; } = null!;

    public virtual ICollection<SgaElementosPlan> SgaElementosPlans { get; set; } = new List<SgaElementosPlan>();
}
