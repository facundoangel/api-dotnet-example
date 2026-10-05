using System;
using System.Collections.Generic;

namespace test;

public partial class SgaPropuestasTipo
{
    public int PropuestaTipo { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<SgaPropuesta> SgaPropuesta { get; set; } = new List<SgaPropuesta>();
}
