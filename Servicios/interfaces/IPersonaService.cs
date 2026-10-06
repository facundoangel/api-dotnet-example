using DTO.Persona;
using test;

namespace Servicios.interfaces
{
    public interface IPersonaService
    {
        Task<personaResultadoQueryDTO> getPersona(int nro_pagina, int limite_pagina);

        Task<MdpPersona> FindPersona(string nro_documento);

        Task<string> migracionPersona(PersonaMigracionDTO persona);


        }
}
