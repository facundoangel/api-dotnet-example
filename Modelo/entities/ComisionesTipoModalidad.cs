using System;
using System.Collections.Generic;

namespace test;

public partial class ComisionesTipoModalidad
{
    public short Modalidad { get; set; }

    public string Codigo { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<SaiComisionesAgrupada> SaiComisionesAgrupada { get; set; } = new List<SaiComisionesAgrupada>();
}
