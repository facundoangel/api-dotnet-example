using Microsoft.EntityFrameworkCore;
using Persistencia.Data;
using test;
using DTO.Persona;
using Servicios.interfaces;

namespace Servicios
{
    public class PersonasService : IPersonaService
    {


        private readonly BaseIntraLocalMatiContext _contextIntra;
        private readonly customDBContext _contextCustomDB;

        public PersonasService(BaseIntraLocalMatiContext contextIntra, customDBContext contextCustomDB) {
            _contextIntra = contextIntra;
            _contextCustomDB = contextCustomDB;
        }

        public async Task<personaResultadoQueryDTO> getPersona(int nro_pagina, int limite_pagina)
        {
            var query = _contextIntra.Set<MdpPersona>()
                .AsNoTracking();

            var cantTotalRegistros = await query.CountAsync();
            var cantTotalPaginas = Math.Floor(cantTotalRegistros / (double)limite_pagina);

            if (nro_pagina < 0 || limite_pagina <= 0)
                throw new ArgumentException("Los parametros ingresados no pueden ser negativos");
            if (nro_pagina > cantTotalPaginas)
                throw new ArgumentOutOfRangeException("El número de página no puede ser mayor a la cantidad total de paginas");
   


            IEnumerable<PersonaDTO> responseQuery = await query
                .OrderBy(p => p.Persona)
                .Skip(nro_pagina * limite_pagina)
                .Take(limite_pagina)
                .Select(p => new PersonaDTO
                {
                    Persona = p.Persona,
                    TipoDocumento = p.TipoDocumento,
                    NroDocumento = p.NroDocumento,
                    Apellido = p.Apellido,
                    Nombres = p.Nombres,
                    Sexo = p.Sexo,
                    FechaNacimiento = p.FechaNacimiento,
                })
                .ToListAsync();

            var response = new personaResultadoQueryDTO
            {
                alumnos = responseQuery,
                pagina = nro_pagina,
                cant_alumnos_pagina = limite_pagina,
                total_paginas = cantTotalPaginas,
                total_alumnos = cantTotalRegistros
            };


            return response;
        }
    }
}
