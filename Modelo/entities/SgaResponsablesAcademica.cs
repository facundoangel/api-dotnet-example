using System;
using System.Collections.Generic;

namespace test;

public partial class SgaResponsablesAcademica
{
    public int ResponsableAcademica { get; set; }

    public string Nombre { get; set; } = null!;

    public string Codigo { get; set; } = null!;

    public string? NombreAbreviado { get; set; }

    public virtual ICollection<SaiCotasResponsablesAcademica> SaiCotasResponsablesAcademicas { get; set; } = new List<SaiCotasResponsablesAcademica>();

    public virtual ICollection<SaiInscripcionesRa> SaiInscripcionesRas { get; set; } = new List<SaiInscripcionesRa>();

    public virtual ICollection<SaiTramitesRaPaga> SaiTramitesRaPagas { get; set; } = new List<SaiTramitesRaPaga>();

    public virtual ICollection<SgaPropuesta> Propuesta { get; set; } = new List<SgaPropuesta>();

    public virtual ICollection<SaiSubcommerce> Subcommerces { get; set; } = new List<SaiSubcommerce>();
}
