using System;
using System.Collections.Generic;

namespace test;

public partial class SaiTramitesRaPaga
{
    public int Tramite { get; set; }

    public int ResponsableAcademica { get; set; }

    public bool Paga { get; set; }

    public int? Importe { get; set; }

    public virtual SgaResponsablesAcademica ResponsableAcademicaNavigation { get; set; } = null!;

    public virtual SgaConstancia TramiteNavigation { get; set; } = null!;
}
