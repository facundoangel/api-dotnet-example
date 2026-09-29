using System;
using System.Collections.Generic;

namespace test.Models;

public partial class SgaAlumno
{
    public int Alumno { get; set; }

    public int Persona { get; set; }

    public int Propuesta { get; set; }

    public int PlanVersion { get; set; }

    public int Ubicacion { get; set; }

    public char Regular { get; set; }

    public char Calidad { get; set; }

    public virtual MdpPersona PersonaNavigation { get; set; } = null!;

    public virtual SgaPlanesVersione PlanVersionNavigation { get; set; } = null!;

    public virtual SgaPropuesta PropuestaNavigation { get; set; } = null!;

    public virtual ICollection<SaiElementosCalculado> SaiElementosCalculados { get; set; } = new List<SaiElementosCalculado>();

    public virtual ICollection<SaiSolicitudTramite> SaiSolicitudTramites { get; set; } = new List<SaiSolicitudTramite>();

    public virtual ICollection<SgaInscCursada> SgaInscCursada { get; set; } = new List<SgaInscCursada>();

    public virtual ICollection<SgaInscExaman> SgaInscExamen { get; set; } = new List<SgaInscExaman>();

    public virtual ICollection<U817TramiteSolicitud> U817TramiteSolicituds { get; set; } = new List<U817TramiteSolicitud>();
}
