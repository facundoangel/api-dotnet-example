using System;
using System.Collections.Generic;

namespace test;

public partial class SgaAsignacione
{
    public int Asignacion { get; set; }

    public string? DiaSemana { get; set; }

    public TimeOnly? HoraInicio { get; set; }

    public TimeOnly? HoraFinalizacion { get; set; }

    public virtual ICollection<SgaComisionesBh> SgaComisionesBhs { get; set; } = new List<SgaComisionesBh>();
}
