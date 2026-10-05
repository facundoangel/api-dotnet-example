using System;
using System.Collections.Generic;

namespace test;

public partial class SgaPlane
{
    public int Plan { get; set; }

    public int Propuesta { get; set; }

    public string? Nombre { get; set; }

    public string Codigo { get; set; } = null!;

    public int? VersionActual { get; set; }

    public char InscripcionHabilitada { get; set; }

    public char Estado { get; set; }

    public string TipoPlan { get; set; } = null!;

    public bool Cobrable { get; set; }

    public virtual SgaPlanesEstado EstadoNavigation { get; set; } = null!;

    public virtual SgaPropuesta PropuestaNavigation { get; set; } = null!;

    public virtual ICollection<SaiSolicitudAnaliticoParcial> SaiSolicitudAnaliticoParcials { get; set; } = new List<SaiSolicitudAnaliticoParcial>();

    public virtual ICollection<SaiSolicitudMateriasAprobada> SaiSolicitudMateriasAprobada { get; set; } = new List<SaiSolicitudMateriasAprobada>();

    public virtual ICollection<SgaComisionesPropuesta> SgaComisionesPropuesta { get; set; } = new List<SgaComisionesPropuesta>();

    public virtual ICollection<SgaPlanesVersione> SgaPlanesVersiones { get; set; } = new List<SgaPlanesVersione>();

    public virtual ICollection<U817TramiteSolicitudDetalle> U817TramiteSolicitudDetalles { get; set; } = new List<U817TramiteSolicitudDetalle>();
}
