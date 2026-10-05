using System;
using System.Collections.Generic;

namespace test;

public partial class SgaCertificado
{
    public int Certificado { get; set; }

    public string Nombre { get; set; } = null!;

    public string NombreFemenino { get; set; } = null!;

    public string Codigo { get; set; } = null!;

    public string TituloNivel { get; set; } = null!;

    public char Estado { get; set; }

    public virtual ICollection<SaiSolicitudAnaliticoParcial> SaiSolicitudAnaliticoParcials { get; set; } = new List<SaiSolicitudAnaliticoParcial>();

    public virtual ICollection<SaiSolicitudLegalizacionPrograma> SaiSolicitudLegalizacionProgramas { get; set; } = new List<SaiSolicitudLegalizacionPrograma>();

    public virtual ICollection<SaiSolicitudMateriasAprobada> SaiSolicitudMateriasAprobada { get; set; } = new List<SaiSolicitudMateriasAprobada>();

    public virtual ICollection<U817TramiteSolicitudDetalle> U817TramiteSolicitudDetalles { get; set; } = new List<U817TramiteSolicitudDetalle>();
}
