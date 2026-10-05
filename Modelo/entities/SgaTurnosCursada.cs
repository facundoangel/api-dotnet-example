using System;
using System.Collections.Generic;

namespace test;

public partial class SgaTurnosCursada
{
    public int Turno { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public virtual ICollection<SgaComisione> SgaComisiones { get; set; } = new List<SgaComisione>();
}
