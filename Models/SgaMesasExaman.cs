using System;
using System.Collections.Generic;

namespace test.Models;

public partial class SgaMesasExaman
{
    public int MesaExamen { get; set; }

    public string? Nombre { get; set; }

    public int Elemento { get; set; }

    public int Ubicacion { get; set; }

    public string? Observaciones { get; set; }

    public char MesaEnTurnoExamen { get; set; }

    public int? AnioAcademico { get; set; }

    public string? Condicion { get; set; }

    public virtual SgaElemento ElementoNavigation { get; set; } = null!;

    public virtual SgaLlamadosMesa? SgaLlamadosMesa { get; set; }

    public virtual ICollection<SgaMesasExamenInstancia> SgaMesasExamenInstancia { get; set; } = new List<SgaMesasExamenInstancia>();
}
