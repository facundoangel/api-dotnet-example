using System;
using System.Collections.Generic;

namespace test.Models;

public partial class SaiCuponPagoEstado
{
    public int Estado { get; set; }

    public string Descripcion { get; set; } = null!;

    public string EstadoId { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public virtual ICollection<SaiCuponPago> SaiCuponPagos { get; set; } = new List<SaiCuponPago>();
}
