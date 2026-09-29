using System;
using System.Collections.Generic;

namespace test.Models;

public partial class SgaInscripcionesEstado
{
    public char Estado { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public virtual ICollection<SgaInscCursada> SgaInscCursada { get; set; } = new List<SgaInscCursada>();
}
