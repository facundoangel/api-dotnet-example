using System;
using System.Collections.Generic;

namespace test.Models;

public partial class SaiInscripcionesRa
{
    public int PeriodoLectivo { get; set; }

    public int ResponsableAcademica { get; set; }

    public int Terminacion { get; set; }

    public DateTime FechaInicio { get; set; }

    public DateTime FechaFin { get; set; }

    public virtual SgaPeriodosLectivo PeriodoLectivoNavigation { get; set; } = null!;

    public virtual SgaResponsablesAcademica ResponsableAcademicaNavigation { get; set; } = null!;
}
