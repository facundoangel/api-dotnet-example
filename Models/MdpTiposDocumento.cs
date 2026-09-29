using System;
using System.Collections.Generic;

namespace test.Models;

public partial class MdpTiposDocumento
{
    public short TipoDocumento { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<MdpPersona> MdpPersonas { get; set; } = new List<MdpPersona>();
}
