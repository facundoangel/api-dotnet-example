using System;
using System.Collections.Generic;

namespace test.Models;

public partial class SgaModalidadCursadum
{
    public char Modalidad { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public virtual ICollection<SgaComisione> Comisions { get; set; } = new List<SgaComisione>();
}
