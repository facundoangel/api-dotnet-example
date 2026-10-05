using System;
using System.Collections.Generic;

namespace test;

public partial class SgaInscExaman
{
    public int Inscripcion { get; set; }

    public int Alumno { get; set; }

    public int LlamadoMesa { get; set; }

    public DateTime FechaInscripcion { get; set; }

    public int? CuponPago { get; set; }

    public string? Estado { get; set; }

    public string? Motivo { get; set; }

    public string Condicion { get; set; } = null!;

    public virtual SgaAlumno AlumnoNavigation { get; set; } = null!;

    public virtual SaiCuponPago? CuponPagoNavigation { get; set; }

    public virtual SgaLlamadosMesa LlamadoMesaNavigation { get; set; } = null!;
}
