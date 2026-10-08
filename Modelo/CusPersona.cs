using Microsoft.AspNetCore.Identity;
using test;

namespace Modelo
{

    public class CusPersona : IdentityUser<int>
    {

        public int persona { get; set; }

        public short tipo_documento { get; set; }

        public string nro_documento { get; set; } = null!;

        public string apellido { get; set; } = null!;

        public string nombres { get; set; } = null!;

        public char sexo { get; set; }

        public DateOnly? fecha_nacimiento { get; set; }

        public string? token { get; set; }

        public short email_valido { get; set; }

        public int? identidad_genero { get; set; }

        public string? mail_institucional { get; set; }

        public string? domicilio { get; set; }

        public string? provincia { get; set; }

        public string? nacionalidad { get; set; }

        public string? estado_civil { get; set; }

        public string? telefono { get; set; }

        public string? mail_personal { get; set; }

        public string? localidad { get; set; }

        /*public virtual ICollection<SaiSancione> SaiSanciones { get; set; } = new List<SaiSancione>();

        public virtual ICollection<SaiSolicitudTramite> SaiSolicitudTramites { get; set; } = new List<SaiSolicitudTramite>();

        public virtual ICollection<SgaAlumno> SgaAlumnos { get; set; } = new List<SgaAlumno>();

        public virtual MdpTiposDocumento TipoDocumentoNavigation { get; set; } = null!;*/


        public static explicit operator CusPersona(MdpPersona p) => new CusPersona
        {
            persona = p.Persona,
            tipo_documento = p.TipoDocumento,
            nro_documento = p.NroDocumento,
            apellido = p.Apellido,
            nombres = p.Nombres,
            sexo = p.Sexo,
            fecha_nacimiento = p.FechaNacimiento,
            token = p.Token,
            email_valido = p.EmailValido,
            identidad_genero = p.IdentidadGenero,
            mail_institucional = p.MailInstitucional,
            domicilio = p.Domicilio,
            provincia = p.Provincia,
            nacionalidad = p.Nacionalidad,
            estado_civil = p.EstadoCivil,
            telefono = p.Telefono,
            mail_personal = p.MailPersonal,
            localidad = p.Localidad,
            /*SaiSanciones = p.SaiSanciones,
            SaiSolicitudTramites = p.SaiSolicitudTramites,
            SgaAlumnos = p.SgaAlumnos,
            TipoDocumentoNavigation = p.TipoDocumentoNavigation */
        };
    }


}
