using System;
using System.Collections.Generic;

namespace test.Models;

public partial class U817SgaComisione
{
    public int ComisionPk { get; set; }

    public int ComisionFk { get; set; }

    public int? Modalidad { get; set; }

    public int? ComisionSuperposicion { get; set; }

    public virtual SgaComisione ComisionFkNavigation { get; set; } = null!;

    public virtual SgaComisione? ComisionSuperposicionNavigation { get; set; }
}
