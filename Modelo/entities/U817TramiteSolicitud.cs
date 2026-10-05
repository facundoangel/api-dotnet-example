using System;
using System.Collections.Generic;

namespace test;

public partial class U817TramiteSolicitud
{
    public int? Solicitud { get; set; }

    public int Alumno { get; set; }

    public DateTime FechaSolicitud { get; set; }

    public DateTime? FechaProceso { get; set; }

    public int? ProcesadoPor { get; set; }

    public DateTime? FechaEntrega { get; set; }

    public int? EntregadoPor { get; set; }

    public string? PresentarA { get; set; }

    public string? Observaciones { get; set; }

    public short Interfaz { get; set; }

    public int NroTransaccion { get; set; }

    public int Circuito { get; set; }

    public int Estado { get; set; }

    public DateOnly? FechaFinVigencia { get; set; }

    public string? CodigoVerificacion { get; set; }

    public string? ObservacionesInternas { get; set; }

    public virtual SgaAlumno AlumnoNavigation { get; set; } = null!;

    public virtual SgaConstancia CircuitoNavigation { get; set; } = null!;

    public virtual SaiSolicitudTramite NroTransaccionNavigation { get; set; } = null!;

    public virtual U817TramiteSolicitudDetalle? U817TramiteSolicitudDetalle { get; set; }
}
