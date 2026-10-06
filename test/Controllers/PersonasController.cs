using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.FeatureManagement.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using DTO;
using DTO.Persona;
using Modelo;
using Persistencia.Data;
using Servicios;
using Servicios.interfaces;



namespace test.Controllers
{
    [FeatureGate("PersonasController")]
    [Route("api/[controller]")]
    [ApiController]
    public class PersonasController : ControllerBase
    {

        private readonly BaseIntraLocalMatiContext _contextIntra;
        private readonly customDBContext _contextCustomDB;
        private readonly IPersonaService _personaService;

        public PersonasController(BaseIntraLocalMatiContext contextIntra, customDBContext contextCustomDB, IPersonaService personaService) {
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
        public async Task<IActionResult> FindPersona(string nro_documento)
        {
            var response = await _personaService.FindPersona(nro_documento);

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
        public async Task<IActionResult> migracionPersona(PersonaMigracionDTO persona)
        {
            var response = await _personaService.migracionPersona(persona);

            return Ok(response);
        }


    }
}
