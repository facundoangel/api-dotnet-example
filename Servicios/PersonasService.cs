using DTO;
using DTO.Persona;
using Microsoft.EntityFrameworkCore;
using Modelo;
using Persistencia.Data;
using Servicios.interfaces;
using test;

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

        public async Task<MdpPersona> FindPersona(string nro_documento)
        {
            var response = await _contextIntra.Set<MdpPersona>().Where(x => x.NroDocumento == nro_documento).FirstAsync();

            if (response == null)
                throw new Exception("Alumno no encontrado");

            return response;
        }


        public async Task<string> migracionPersona(PersonaMigracionDTO persona)
        {
            MdpPersona responseQuery = await _contextIntra.Set<MdpPersona>().Where(x => x.NroDocumento == persona.dni).FirstAsync();

            if (responseQuery == null)
                throw new Exception("No existe la persona con el dni provisto");

            CusPersona nuevaPersonaAMigrar = new CusPersona
            {
                Persona = responseQuery.Persona,
                TipoDocumento = responseQuery.TipoDocumento,
                NroDocumento = responseQuery.NroDocumento,
                Apellido = responseQuery.Apellido,
                Nombres = responseQuery.Nombres,
                Sexo = responseQuery.Sexo,
                FechaNacimiento = responseQuery.FechaNacimiento,
                Token = responseQuery.Token,
                EmailValido = responseQuery.EmailValido,
                IdentidadGenero = responseQuery.IdentidadGenero,
                MailInstitucional = responseQuery.MailInstitucional,
                Domicilio = responseQuery.Domicilio,
                Provincia = responseQuery.Provincia,
                Nacionalidad = responseQuery.Nacionalidad,
                EstadoCivil = responseQuery.EstadoCivil,
                Telefono = responseQuery.Telefono,
                MailPersonal = responseQuery.MailPersonal,
                Localidad = responseQuery.Localidad,
                NormalizedUserName = responseQuery.NormalizedUserName,
                PasswordHash = responseQuery.PasswordHash,
                SecurityStamp = responseQuery.SecurityStamp,
                ConcurrencyStamp = responseQuery.ConcurrencyStamp,
                AccessFailedCount = responseQuery.AccessFailedCount,
            };
            var responseMigration = await _contextCustomDB.Set<CusPersona>().AddAsync(nuevaPersonaAMigrar);
            var affectedRows = await _contextCustomDB.SaveChangesAsync();

            if (affectedRows == 0)
                throw new Exception("No se pudo crear a migrar a la persona");


            return "se ha migrado con exito la persona";
        }
    }
}
