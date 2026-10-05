using System;
using System.Collections.Generic;

namespace test;

public partial class SgaPeriodosLectivo
{
    public int PeriodoLectivo { get; set; }

    public int Periodo { get; set; }

    public virtual SgaPeriodo PeriodoNavigation { get; set; } = null!;

    public virtual ICollection<SaiComisionesAgrupada> SaiComisionesAgrupada { get; set; } = new List<SaiComisionesAgrupada>();

    public virtual ICollection<SaiCotasResponsablesAcademica> SaiCotasResponsablesAcademicas { get; set; } = new List<SaiCotasResponsablesAcademica>();

    public virtual ICollection<SaiInscripcionesRa> SaiInscripcionesRas { get; set; } = new List<SaiInscripcionesRa>();

    public virtual ICollection<SaiSancione> SaiSanciones { get; set; } = new List<SaiSancione>();

    public virtual ICollection<SgaComisione> SgaComisiones { get; set; } = new List<SgaComisione>();
}
