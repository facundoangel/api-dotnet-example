using System;
using System.Collections.Generic;

namespace test;

public partial class MugPaise
{
    public int Pais { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<SaiSolicitudLegalizacionPrograma> SaiSolicitudLegalizacionProgramas { get; set; } = new List<SaiSolicitudLegalizacionPrograma>();
}
