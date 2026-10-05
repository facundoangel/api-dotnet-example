using System;
using System.Collections.Generic;

namespace test;

public partial class SgaComisionesPropuesta
{
    public int Comision { get; set; }

    public int Propuesta { get; set; }

    public int Plan { get; set; }

    public virtual SgaComisione ComisionNavigation { get; set; } = null!;

    public virtual SgaPlane PlanNavigation { get; set; } = null!;

    public virtual SgaPropuesta PropuestaNavigation { get; set; } = null!;
}
