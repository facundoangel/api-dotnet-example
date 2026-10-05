using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.FeatureManagement.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using DTO;
using DTO.Persona;
using Modelo;
using Persistencia.Data;
using Servicios;



namespace test.Controllers
{
    [FeatureGate("PersonasController")]
    [Route("api/[controller]")]
    [ApiController]
    public class PersonasController : ControllerBase
    {

        private readonly BaseIntraLocalMatiContext _contextIntra;
        private readonly customDBContext _contextCustomDB;
        private readonly PersonasService _personaService;

        public PersonasController(BaseIntraLocalMatiContext contextIntra, customDBContext contextCustomDB, PersonasService personaService) {
            _contextIntra = contextIntra;
            _contextCustomDB = contextCustomDB;
            _personaService = personaService;
        }



        [HttpGet("{nro_pagina}/{limite_pagina}")]
        [SwaggerOperation(
            Summary = "Obtener listado de personas",
            Description = "Devuelve una lista con las personas desde la copia de base de datos de intra local",
            OperationId = "getPersonas",
            Tags = new[] { "Personas" }
        )]
        [SwaggerResponse(StatusCodes.Status200OK, "Devuelve una lista de personas sacadas desde la base local de intra", typeof(personaResultadoQueryDTO))]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, "Error interno al procesamiento de la petición", typeof(ErrorOperacion))]
        [SwaggerResponse(StatusCodes.Status400BadRequest, "Error En algunos de los parametros colocados", typeof(ErrorOperacion))]
        public async Task<IActionResult>  GetPersonas(int nro_pagina, int limite_pagina)
        {


            /*var query = _contextIntra.Set<MdpPersona>()
                .AsNoTracking();

            var cantTotalRegistros = await query.CountAsync();
            var cantTotalPaginas = Math.Floor(cantTotalRegistros / (double)limite_pagina);

            if (nro_pagina < 0 || limite_pagina <= 0)
                return BadRequest(new ErrorDTO
                {
                    StatusCode=400,
                    Mensaje="Error en los parametros de la consulta ingresados",
                    Detalle="Los parametros ingresados no pueden ser negativos"
                });
            if(nro_pagina > cantTotalPaginas)
                return BadRequest(new ErrorDTO
                {
                    StatusCode = 400,
                    Mensaje = "Error en los parametros de la consulta ingresados",
                    Detalle = "El número de página no puede ser mayor a la cantidad total de paginas"
                });


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

            */

            var response = await _personaService.getPersona(nro_pagina, limite_pagina);

            return Ok(response);
        }

        
        [HttpGet("{nro_documento}")]
        [SwaggerOperation(
            Summary = "Obtener alumno",
            Description = "Devuelve un alumno buscado por el número de DNI brindado",
            OperationId = "FindPersona",
            Tags = new[] { "Personas" }
        )]
        [SwaggerResponse(StatusCodes.Status200OK, "Devuelve una lista con el historial academico de la persona, separado por carrera", typeof(PersonaDTO))]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, "Error interno al procesamiento de la petición", typeof(ErrorOperacion))]
        public async Task<ActionResult<MdpPersona>> FindPersona(string nro_documento)
        {
            var response = await _contextIntra.Set<MdpPersona>().Where(x => x.NroDocumento == nro_documento).FirstAsync();

            if (response == null)
                return NotFound(new ErrorOperacion
                {
                    StatusCode=404,
                    Message="Alumno no encontrado",
                    
                });

            return Ok(response);
        }


        
        [HttpPost]
        [SwaggerOperation(
            Summary = "migrar alumno",
            Description = "Migra un alumno desde la base de datos de intra local a la base de datos personalizada",
            OperationId = "migracionPersona",
            Tags = new[] { "Personas" }
        )]
        [SwaggerResponse(StatusCodes.Status200OK, "Devuelve un string", typeof(CusPersona))]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, "Error interno al procesamiento de la petición", typeof(ErrorOperacion))]
        public async Task<ActionResult<string>> migracionPersona(PersonaMigracionDTO persona)
        {
            MdpPersona responseQuery = await _contextIntra.Set<MdpPersona>().Where(x => x.NroDocumento == persona.dni).FirstAsync();

            CusPersona nuevaPersonaAMigrar = new CusPersona
            {
                Persona          = responseQuery.Persona,
                TipoDocumento    = responseQuery.TipoDocumento,
                NroDocumento     = responseQuery.NroDocumento,
                Apellido         = responseQuery.Apellido,
                Nombres          = responseQuery.Nombres,
                Sexo             = responseQuery.Sexo,
                FechaNacimiento  = responseQuery.FechaNacimiento,
                Token            = responseQuery.Token,
                EmailValido      = responseQuery.EmailValido,
                IdentidadGenero  = responseQuery.IdentidadGenero,
                MailInstitucional = responseQuery.MailInstitucional,
                Domicilio        = responseQuery.Domicilio,
                Provincia        = responseQuery.Provincia,
                Nacionalidad     = responseQuery.Nacionalidad,
                EstadoCivil      = responseQuery.EstadoCivil,
                Telefono         = responseQuery.Telefono,
                MailPersonal     = responseQuery.MailPersonal,
                Localidad        = responseQuery.Localidad,
                NormalizedUserName = responseQuery.NormalizedUserName,
                PasswordHash     = responseQuery.PasswordHash,
                SecurityStamp    = responseQuery.SecurityStamp,
                ConcurrencyStamp = responseQuery.ConcurrencyStamp,
                AccessFailedCount = responseQuery.AccessFailedCount,
            };
            var responseMigration = await _contextCustomDB.Set<CusPersona>().AddAsync(nuevaPersonaAMigrar);
            _contextCustomDB.SaveChanges();

            return Ok(responseMigration);
        }


    }
}
