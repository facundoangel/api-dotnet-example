using System;
using System.Collections.Generic;

namespace test;

public partial class SaiCuponPago
{
    public int CuponPago { get; set; }

    public int Importe { get; set; }

    public string? Link { get; set; }

    public int Estado { get; set; }

    public string? NroFacturaPpt { get; set; }

    public DateTime? FechaPago { get; set; }

    public DateTime FechaCreacion { get; set; }

    public DateTime FechaActualizacion { get; set; }

    public DateOnly FechaVencimiento { get; set; }

    public string? Observaciones { get; set; }

    public virtual SaiCuponPagoEstado EstadoNavigation { get; set; } = null!;

    public virtual SaiSolicitudTramite? SaiSolicitudTramite { get; set; }

    public virtual SgaInscCursada? SgaInscCursada { get; set; }

    public virtual SgaInscExaman? SgaInscExaman { get; set; }
}
