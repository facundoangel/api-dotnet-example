using System;
using System.Collections.Generic;

namespace test.Models;

public partial class SgaPlanesVersione
{
    public int PlanVersion { get; set; }

    public int Plan { get; set; }

    public string Version { get; set; } = null!;

    public string? Nombre { get; set; }

    public char Estado { get; set; }

    public virtual SgaPlane PlanNavigation { get; set; } = null!;

    public virtual ICollection<SaiSolicitudLegalizacionPrograma> SaiSolicitudLegalizacionProgramas { get; set; } = new List<SaiSolicitudLegalizacionPrograma>();

    public virtual ICollection<SgaAlumno> SgaAlumnos { get; set; } = new List<SgaAlumno>();

    public virtual ICollection<SgaElementosPlan> SgaElementosPlans { get; set; } = new List<SgaElementosPlan>();

    public virtual ICollection<SgaInscCursada> SgaInscCursada { get; set; } = new List<SgaInscCursada>();
}
