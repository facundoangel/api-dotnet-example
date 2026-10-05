using System;
using System.Collections.Generic;

namespace test;

public partial class SaiSolicitudTramite
{
    public int Solicitud { get; set; }

    public int Persona { get; set; }

    public int Alumno { get; set; }

    public int Constancia { get; set; }

    public int Estado { get; set; }

    public DateTime FechaSolicitud { get; set; }

    public DateTime? FechaActualizacion { get; set; }

    public DateTime? FechaEntrega { get; set; }

    public int? CuponPago { get; set; }

    public string? Mail { get; set; }

    public virtual SgaAlumno AlumnoNavigation { get; set; } = null!;

    public virtual SgaConstancia ConstanciaNavigation { get; set; } = null!;

    public virtual SaiCuponPago? CuponPagoNavigation { get; set; }

    public virtual SaiTramitesEstado EstadoNavigation { get; set; } = null!;

    public virtual MdpPersona PersonaNavigation { get; set; } = null!;

    public virtual SaiSolicitudAlumnoRegular? SaiSolicitudAlumnoRegular { get; set; }

    public virtual SaiSolicitudAnaliticoParcial? SaiSolicitudAnaliticoParcial { get; set; }

    public virtual SaiSolicitudLegalizacionPrograma? SaiSolicitudLegalizacionPrograma { get; set; }

    public virtual SaiSolicitudMateriasAprobada? SaiSolicitudMateriasAprobada { get; set; }

    public virtual U817TramiteSolicitud? U817TramiteSolicitud { get; set; }

    public virtual ICollection<SgaElemento> Elementos { get; set; } = new List<SgaElemento>();
}
