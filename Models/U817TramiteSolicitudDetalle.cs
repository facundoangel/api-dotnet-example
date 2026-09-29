using System;
using System.Collections.Generic;

namespace test.Models;

public partial class U817TramiteSolicitudDetalle
{
    public int? Solicitud { get; set; }

    public int NroTransaccion { get; set; }

    public bool? Promedio { get; set; }

    public bool? Porcentaje { get; set; }

    public int? Colacion { get; set; }

    public int? Certificado { get; set; }

    public int? ElementoPlanOrientacion { get; set; }

    public string? Diploma { get; set; }

    public int? Acta { get; set; }

    public int? Nota { get; set; }

    public int? CertificadoNoSancion { get; set; }

    public int? CertificadoBajaUniversidad { get; set; }

    public int? CertificadoMateriasAprobadas { get; set; }

    public int? CertificadoAnaliticoParcial { get; set; }

    public int? TotalFojas { get; set; }

    public string? FojasMaterias { get; set; }

    public string? FojasPlanEstudio { get; set; }

    public string? FojasCertificadoMateriasAprobadas { get; set; }

    public string? FojasAnaliticoParcial { get; set; }

    public int? Plan { get; set; }

    public int? CertificadoPlanEstudios { get; set; }

    public string? Email { get; set; }

    public string? HomologacionMateriasOtorgadas { get; set; }

    public string? HomologacionMateriasAprobadas { get; set; }

    public string? HomologacionLibroTomoFolio { get; set; }

    public virtual SgaCertificado? CertificadoNavigation { get; set; }

    public virtual U817TramiteSolicitud NroTransaccionNavigation { get; set; } = null!;

    public virtual SgaPlane? PlanNavigation { get; set; }
}
