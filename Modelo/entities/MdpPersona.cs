using System;
using System.Collections.Generic;

namespace test;

public partial class MdpPersona
{
    public int Persona { get; set; }

    public short TipoDocumento { get; set; }

    public string NroDocumento { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public string Nombres { get; set; } = null!;

    public char Sexo { get; set; }

    public DateOnly? FechaNacimiento { get; set; }

    public string? Token { get; set; }

    public short EmailValido { get; set; }

    public int? IdentidadGenero { get; set; }

    public string? MailInstitucional { get; set; }

    public string? Domicilio { get; set; }

    public string? Provincia { get; set; }

    public string? Nacionalidad { get; set; }

    public string? EstadoCivil { get; set; }

    public string? Telefono { get; set; }

    public string? MailPersonal { get; set; }

    public string? Localidad { get; set; }

    public string? NormalizedUserName { get; set; }

    public string? PasswordHash { get; set; }

    public string? SecurityStamp { get; set; }

    public string? ConcurrencyStamp { get; set; }

    public int AccessFailedCount { get; set; }

    public virtual ICollection<SaiSancione> SaiSanciones { get; set; } = new List<SaiSancione>();

    public virtual ICollection<SaiSolicitudTramite> SaiSolicitudTramites { get; set; } = new List<SaiSolicitudTramite>();

    public virtual ICollection<SgaAlumno> SgaAlumnos { get; set; } = new List<SgaAlumno>();

    public virtual MdpTiposDocumento TipoDocumentoNavigation { get; set; } = null!;
}
