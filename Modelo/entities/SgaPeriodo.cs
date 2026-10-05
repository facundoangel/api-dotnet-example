using System;
using System.Collections.Generic;

namespace test;

public partial class SgaPeriodo
{
    public int Periodo { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public decimal AnioAcademico { get; set; }

    public DateOnly FechaInicio { get; set; }

    public DateOnly FechaFin { get; set; }

    public int? TipoPeriodo { get; set; }

    public virtual ICollection<SgaLlamadosTurno> SgaLlamadosTurnos { get; set; } = new List<SgaLlamadosTurno>();

    public virtual SgaPeriodosLectivo? SgaPeriodosLectivo { get; set; }

    public virtual SaiPeriodosTipo? TipoPeriodoNavigation { get; set; }
}
