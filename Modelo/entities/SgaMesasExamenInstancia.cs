using System;
using System.Collections.Generic;

namespace test;

public partial class SgaMesasExamenInstancia
{
    public int MesaExamen { get; set; }

    public short Instancia { get; set; }

    public virtual SgaMesasExaman MesaExamenNavigation { get; set; } = null!;
}
