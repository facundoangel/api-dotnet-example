using System;
using System.Collections.Generic;

namespace test.Models;

public partial class SgaInscCursada
{
    public int Inscripcion { get; set; }

    public int ComisionAgrupada { get; set; }

    public int Alumno { get; set; }

    public char Tipo { get; set; }

    public int PlanVersion { get; set; }

    public DateTime FechaInscripcion { get; set; }

    public int? NroTransaccion { get; set; }

    public char Estado { get; set; }

    public int? CuponPago { get; set; }

    public virtual SgaAlumno AlumnoNavigation { get; set; } = null!;

    public virtual SaiComisionesAgrupada ComisionAgrupadaNavigation { get; set; } = null!;

    public virtual SaiCuponPago? CuponPagoNavigation { get; set; }

    public virtual SgaInscripcionesEstado EstadoNavigation { get; set; } = null!;

    public virtual SgaPlanesVersione PlanVersionNavigation { get; set; } = null!;
}
