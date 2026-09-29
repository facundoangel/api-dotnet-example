using System;
using System.Collections.Generic;

namespace test.Models;

public partial class SgaElemento
{
    public int Elemento { get; set; }

    public string Nombre { get; set; } = null!;

    public string NombreAbreviado { get; set; } = null!;

    public string? Codigo { get; set; }

    public char Compartible { get; set; }

    public char Estado { get; set; }

    public virtual SgaElementosEstado EstadoNavigation { get; set; } = null!;

    public virtual ICollection<SaiComisionesAgrupada> SaiComisionesAgrupada { get; set; } = new List<SaiComisionesAgrupada>();

    public virtual ICollection<SaiCotasResponsablesAcademica> SaiCotasResponsablesAcademicas { get; set; } = new List<SaiCotasResponsablesAcademica>();

    public virtual ICollection<SaiElementosCalculado> SaiElementosCalculados { get; set; } = new List<SaiElementosCalculado>();

    public virtual ICollection<SaiSancione> SaiSanciones { get; set; } = new List<SaiSancione>();

    public virtual ICollection<SgaComisione> SgaComisiones { get; set; } = new List<SgaComisione>();

    public virtual ICollection<SgaElementosRevision> SgaElementosRevisions { get; set; } = new List<SgaElementosRevision>();

    public virtual ICollection<SgaMesasExaman> SgaMesasExamen { get; set; } = new List<SgaMesasExaman>();

    public virtual ICollection<SaiSolicitudTramite> Solicituds { get; set; } = new List<SaiSolicitudTramite>();
}
