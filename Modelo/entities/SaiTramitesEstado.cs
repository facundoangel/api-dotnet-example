using System;
using System.Collections.Generic;

namespace test;

public partial class SaiTramitesEstado
{
    public int Estado { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public virtual ICollection<SaiSolicitudTramite> SaiSolicitudTramites { get; set; } = new List<SaiSolicitudTramite>();
}
