using System;
using System.Collections.Generic;

namespace test;

public partial class SaiCotasResponsablesAcademica
{
    public int CotaResponsable { get; set; }

    public int Elemento { get; set; }

    public int PeriodoLectivo { get; set; }

    public int ResponsableAcademica { get; set; }

    public int Cota { get; set; }

    public virtual SgaElemento ElementoNavigation { get; set; } = null!;

    public virtual SgaPeriodosLectivo PeriodoLectivoNavigation { get; set; } = null!;

    public virtual SgaResponsablesAcademica ResponsableAcademicaNavigation { get; set; } = null!;
}
