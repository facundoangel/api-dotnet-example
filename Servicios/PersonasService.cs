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
        private readonly CustomDBContext _contextCustomDB;

        public PersonasService(BaseIntraLocalMatiContext contextIntra, CustomDBContext contextCustomDB) {
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
                persona = responseQuery.Persona,
                tipo_documento = responseQuery.TipoDocumento,
                nro_documento = responseQuery.NroDocumento,
                apellido = responseQuery.Apellido,
                nombres = responseQuery.Nombres,
                sexo = responseQuery.Sexo,
                fecha_nacimiento = responseQuery.FechaNacimiento,
                token = responseQuery.Token,
                email_valido = responseQuery.EmailValido,
                identidad_genero = responseQuery.IdentidadGenero,
                mail_institucional = responseQuery.MailInstitucional,
                domicilio = responseQuery.Domicilio,
                provincia = responseQuery.Provincia,
                nacionalidad = responseQuery.Nacionalidad,
                estado_civil = responseQuery.EstadoCivil,
                telefono = responseQuery.Telefono,
                mail_personal = responseQuery.MailPersonal,
                localidad = responseQuery.Localidad,

            };
            var responseMigration = await _contextCustomDB.Set<CusPersona>().AddAsync(nuevaPersonaAMigrar);
            var affectedRows = await _contextCustomDB.SaveChangesAsync();

            if (affectedRows == 0)
                throw new Exception("No se pudo crear a migrar a la persona");


            return "se ha migrado con exito la persona";
        }
    }
}
