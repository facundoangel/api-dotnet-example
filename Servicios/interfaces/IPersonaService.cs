using DTO.Persona;

namespace Servicios.interfaces
{
    public interface IPersonaService
    {
        Task<personaResultadoQueryDTO> getPersona(int nro_pagina, int limite_pagina);
    }
}
