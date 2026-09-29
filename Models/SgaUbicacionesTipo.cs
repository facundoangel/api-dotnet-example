using System;
using System.Collections.Generic;

namespace test.Models;

public partial class SgaUbicacionesTipo
{
    public int UbicacionTipo { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public virtual ICollection<SgaUbicacione> SgaUbicaciones { get; set; } = new List<SgaUbicacione>();
}
