using System;
using System.Collections.Generic;

namespace test;

public partial class SgaLlamadosMesa
{
    public int LlamadoMesa { get; set; }

    public int MesaExamen { get; set; }

    public DateOnly Fecha { get; set; }

    public TimeOnly HoraInicio { get; set; }

    public TimeOnly? HoraFinalizacion { get; set; }

    public char Estado { get; set; }

    public short? Cupo { get; set; }

    public string? Motivo { get; set; }

    public string? Instancia { get; set; }

    public int? Llamado { get; set; }

    public virtual SgaLlamadosTurno? LlamadoNavigation { get; set; }

    public virtual SgaMesasExaman MesaExamenNavigation { get; set; } = null!;

    public virtual ICollection<SgaInscExaman> SgaInscExamen { get; set; } = new List<SgaInscExaman>();
}
