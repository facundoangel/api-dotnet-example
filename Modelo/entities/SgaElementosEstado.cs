using System;
using System.Collections.Generic;

namespace test;

public partial class SgaElementosEstado
{
    public char Estado { get; set; }

    public string Descripcion { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public virtual ICollection<SgaElemento> SgaElementos { get; set; } = new List<SgaElemento>();
}
