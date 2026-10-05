

namespace DTO.Persona
{
    public class PersonaDTO
    {
        public int Persona { get; set; }

        public short TipoDocumento { get; set; }

        public string NroDocumento { get; set; } = null!;

        public string Apellido { get; set; } = null!;

        public string Nombres { get; set; } = null!;

        public char Sexo { get; set; }

        public DateOnly? FechaNacimiento { get; set; }
    }
}
