using System;
using System.Collections.Generic;

namespace test;

public partial class SaiCondicione
{
    public int Condicion { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<SaiElementosCalculado> SaiElementosCalculados { get; set; } = new List<SaiElementosCalculado>();
}
