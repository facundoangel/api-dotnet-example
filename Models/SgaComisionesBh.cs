using System;
using System.Collections.Generic;

namespace test.Models;

public partial class SgaComisionesBh
{
    public int BandaHoraria { get; set; }

    public int Comision { get; set; }

    public int Asignacion { get; set; }

    public virtual SgaAsignacione AsignacionNavigation { get; set; } = null!;

    public virtual SgaComisione ComisionNavigation { get; set; } = null!;
}
