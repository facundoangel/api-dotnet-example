using System;
using System.Collections.Generic;

namespace test.Models;

public partial class SgaPropuesta
{
    public int Propuesta { get; set; }

    public string Nombre { get; set; } = null!;

    public string NombreAbreviado { get; set; } = null!;

    public string Codigo { get; set; } = null!;

    public int PropuestaTipo { get; set; }

    public char Publica { get; set; }

    public char Estado { get; set; }

    public virtual SgaPropuestasTipo PropuestaTipoNavigation { get; set; } = null!;

    public virtual ICollection<SgaAlumno> SgaAlumnos { get; set; } = new List<SgaAlumno>();

    public virtual ICollection<SgaComisionesPropuesta> SgaComisionesPropuesta { get; set; } = new List<SgaComisionesPropuesta>();

    public virtual ICollection<SgaPlane> SgaPlanes { get; set; } = new List<SgaPlane>();

    public virtual ICollection<SgaResponsablesAcademica> ResponsableAcademicas { get; set; } = new List<SgaResponsablesAcademica>();
}
