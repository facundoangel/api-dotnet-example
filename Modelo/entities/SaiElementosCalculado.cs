using System;
using System.Collections.Generic;

namespace test;

public partial class SaiElementosCalculado
{
    public int Alumno { get; set; }

    public int Elemento { get; set; }

    public int Condicion { get; set; }

    public bool Acreditacion { get; set; }

    public bool Regularizada { get; set; }

    public virtual SgaAlumno AlumnoNavigation { get; set; } = null!;

    public virtual SaiCondicione CondicionNavigation { get; set; } = null!;

    public virtual SgaElemento ElementoNavigation { get; set; } = null!;
}
