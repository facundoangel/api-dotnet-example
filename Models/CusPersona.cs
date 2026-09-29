using System.ComponentModel.DataAnnotations;

namespace test.Models
{

    public class CusPersona
    {
        [Key]
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

        /*public virtual ICollection<SaiSancione> SaiSanciones { get; set; } = new List<SaiSancione>();

        public virtual ICollection<SaiSolicitudTramite> SaiSolicitudTramites { get; set; } = new List<SaiSolicitudTramite>();

        public virtual ICollection<SgaAlumno> SgaAlumnos { get; set; } = new List<SgaAlumno>();

        public virtual MdpTiposDocumento TipoDocumentoNavigation { get; set; } = null!;*/


        public static explicit operator CusPersona(MdpPersona p) => new CusPersona
        {
            Persona = p.Persona,
            TipoDocumento = p.TipoDocumento,
            NroDocumento = p.NroDocumento,
            Apellido = p.Apellido,
            Nombres = p.Nombres,
            Sexo = p.Sexo,
            FechaNacimiento = p.FechaNacimiento,
            Token = p.Token,
            EmailValido = p.EmailValido,
            IdentidadGenero = p.IdentidadGenero,
            MailInstitucional = p.MailInstitucional,
            Domicilio = p.Domicilio,
            Provincia = p.Provincia,
            Nacionalidad = p.Nacionalidad,
            EstadoCivil = p.EstadoCivil,
            Telefono = p.Telefono,
            MailPersonal = p.MailPersonal,
            Localidad = p.Localidad,
            NormalizedUserName = p.NormalizedUserName,
            PasswordHash = p.PasswordHash,
            SecurityStamp = p.SecurityStamp,
            ConcurrencyStamp = p.ConcurrencyStamp,
            AccessFailedCount = p.AccessFailedCount,
            /*SaiSanciones = p.SaiSanciones,
            SaiSolicitudTramites = p.SaiSolicitudTramites,
            SgaAlumnos = p.SgaAlumnos,
            TipoDocumentoNavigation = p.TipoDocumentoNavigation*/
        };
    }


}
