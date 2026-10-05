using System;
using System.Collections.Generic;

namespace test;

public partial class SaiComisionesAgrupada
{
    public int ComisionAgrupada { get; set; }

    public int Elemento { get; set; }

    public short Modalidad { get; set; }

    public int Ubicacion { get; set; }

    public int PeriodoLectivo { get; set; }

    public string DatosAsignacion { get; set; } = null!;

    public string Llave { get; set; } = null!;

    public virtual SgaElemento ElementoNavigation { get; set; } = null!;

    public virtual ComisionesTipoModalidad ModalidadNavigation { get; set; } = null!;

    public virtual SgaPeriodosLectivo PeriodoLectivoNavigation { get; set; } = null!;

    public virtual ICollection<SaiComisionesAgrupadasDetalle> SaiComisionesAgrupadasDetalles { get; set; } = new List<SaiComisionesAgrupadasDetalle>();

    public virtual ICollection<SgaInscCursada> SgaInscCursada { get; set; } = new List<SgaInscCursada>();
}
