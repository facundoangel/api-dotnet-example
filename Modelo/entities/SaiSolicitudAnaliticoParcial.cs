using System;
using System.Collections.Generic;

namespace test;

public partial class SaiSolicitudAnaliticoParcial
{
    public int Solicitud { get; set; }

    public int Certificado { get; set; }

    public int Plan { get; set; }

    public string? Institucion { get; set; }

    public bool Promedio { get; set; }

    public bool Porcentaje { get; set; }

    public virtual SgaCertificado CertificadoNavigation { get; set; } = null!;

    public virtual SgaPlane PlanNavigation { get; set; } = null!;

    public virtual SaiSolicitudTramite SolicitudNavigation { get; set; } = null!;
}
