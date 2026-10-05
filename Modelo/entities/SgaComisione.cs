using System;
using System.Collections.Generic;

namespace test;

public partial class SgaComisione
{
    public int Comision { get; set; }

    public string Nombre { get; set; } = null!;

    public int PeriodoLectivo { get; set; }

    public int Elemento { get; set; }

    public int? Turno { get; set; }

    public string? Observaciones { get; set; }

    public char Cobrable { get; set; }

    public char Estado { get; set; }

    public char InscripcionHabilitada { get; set; }

    public int? Cupo { get; set; }

    public int Ubicacion { get; set; }

    public virtual SgaElemento ElementoNavigation { get; set; } = null!;

    public virtual SgaPeriodosLectivo PeriodoLectivoNavigation { get; set; } = null!;

    public virtual SaiComisionesAgrupadasDetalle? SaiComisionesAgrupadasDetalle { get; set; }

    public virtual SaiComisionesObservacione? SaiComisionesObservacione { get; set; }

    public virtual ICollection<SgaComisionesBh> SgaComisionesBhs { get; set; } = new List<SgaComisionesBh>();

    public virtual ICollection<SgaComisionesPropuesta> SgaComisionesPropuesta { get; set; } = new List<SgaComisionesPropuesta>();

    public virtual SgaTurnosCursada? TurnoNavigation { get; set; }

    public virtual U817SgaComisione? U817SgaComisioneComisionFkNavigation { get; set; }

    public virtual ICollection<U817SgaComisione> U817SgaComisioneComisionSuperposicionNavigations { get; set; } = new List<U817SgaComisione>();

    public virtual SgaUbicacione UbicacionNavigation { get; set; } = null!;

    public virtual ICollection<SgaModalidadCursadum> Modalidads { get; set; } = new List<SgaModalidadCursadum>();
}
