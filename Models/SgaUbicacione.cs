using System;
using System.Collections.Generic;

namespace test.Models;

public partial class SgaUbicacione
{
    public int Ubicacion { get; set; }

    public string Nombre { get; set; } = null!;

    public int UbicacionTipo { get; set; }

    public int Localidad { get; set; }

    public string? Calle { get; set; }

    public string? Numero { get; set; }

    public string? CodigoPostal { get; set; }

    public string? Telefono { get; set; }

    public string? Fax { get; set; }

    public string? Email { get; set; }

    public decimal? Latitud { get; set; }

    public decimal? Longitud { get; set; }

    public virtual ICollection<SgaComisione> SgaComisiones { get; set; } = new List<SgaComisione>();

    public virtual SgaUbicacionesTipo UbicacionTipoNavigation { get; set; } = null!;
}
