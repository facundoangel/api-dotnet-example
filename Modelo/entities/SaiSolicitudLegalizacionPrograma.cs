using System;
using System.Collections.Generic;

namespace test;

public partial class SaiSolicitudLegalizacionPrograma
{
    public int Solicitud { get; set; }

    public int Certificado { get; set; }

    public int PlanVersion { get; set; }

    public int? Pais { get; set; }

    public string? Institucion { get; set; }

    public string? Organismo { get; set; }

    public bool CertificadoAnaliticoParcial { get; set; }

    public bool CertificadoMateriasAprobadas { get; set; }

    public bool CertificadoNoSancion { get; set; }

    public bool CertificadoBajaUniversidad { get; set; }

    public bool CertificadoPlanEstudio { get; set; }

    public string? Telefono { get; set; }

    public virtual SgaCertificado CertificadoNavigation { get; set; } = null!;

    public virtual MugPaise? PaisNavigation { get; set; }

    public virtual SgaPlanesVersione PlanVersionNavigation { get; set; } = null!;

    public virtual SaiSolicitudTramite SolicitudNavigation { get; set; } = null!;
}
