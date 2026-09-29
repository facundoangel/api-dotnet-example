using System;
using System.Collections.Generic;

namespace test.Models;

public partial class SgaPlanesEstado
{
    public char Estado { get; set; }

    public string Descripcion { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public virtual ICollection<SgaPlane> SgaPlanes { get; set; } = new List<SgaPlane>();
}
