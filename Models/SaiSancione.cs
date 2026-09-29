using System;
using System.Collections.Generic;

namespace test.Models;

public partial class SaiSancione
{
    public int Persona { get; set; }

    public int Elemento { get; set; }

    public int PeriodoLectivo { get; set; }

    public virtual SgaElemento ElementoNavigation { get; set; } = null!;

    public virtual SgaPeriodosLectivo PeriodoLectivoNavigation { get; set; } = null!;

    public virtual MdpPersona PersonaNavigation { get; set; } = null!;
}
