using System;
using System.Collections.Generic;

namespace test;

public partial class SaiSolicitudAlumnoRegular
{
    public int Solicitud { get; set; }

    public string? Institucion { get; set; }

    public virtual SaiSolicitudTramite SolicitudNavigation { get; set; } = null!;
}
