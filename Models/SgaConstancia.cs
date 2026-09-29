using System;
using System.Collections.Generic;

namespace test.Models;

public partial class SgaConstancia
{
    public int Constancia { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public int? EstadoInicial { get; set; }

    public virtual ICollection<SaiSolicitudTramite> SaiSolicitudTramites { get; set; } = new List<SaiSolicitudTramite>();

    public virtual ICollection<SaiTramitesAdicionale> SaiTramitesAdicionales { get; set; } = new List<SaiTramitesAdicionale>();

    public virtual ICollection<SaiTramitesRaPaga> SaiTramitesRaPagas { get; set; } = new List<SaiTramitesRaPaga>();

    public virtual ICollection<U817TramiteSolicitud> U817TramiteSolicituds { get; set; } = new List<U817TramiteSolicitud>();
}
