using System;
using System.Collections.Generic;

namespace test;

public partial class SgaElementosPlan
{
    public int ElementoPlan { get; set; }

    public int PlanVersion { get; set; }

    public int ElementoRevision { get; set; }

    public string Nombre { get; set; } = null!;

    public char Cobrable { get; set; }

    public virtual SgaElementosRevision ElementoRevisionNavigation { get; set; } = null!;

    public virtual SgaPlanesVersione PlanVersionNavigation { get; set; } = null!;
}
