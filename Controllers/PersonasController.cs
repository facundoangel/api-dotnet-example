using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.FeatureManagement.Mvc;
using test.Models;
using test.persistance;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace test.Controllers
{
    [FeatureGate("PersonasController")]
    [Route("api/[controller]")]
    [ApiController]
    public class PersonasController : ControllerBase
    {

        private readonly BaseIntraLocalMatiContext _contextIntra;
        private readonly customDBContext _contextCustomDB;

        public PersonasController(BaseIntraLocalMatiContext contextIntra, customDBContext contextCustomDB) {
            _contextIntra = contextIntra;
            _contextCustomDB = contextCustomDB;
        }


        // GET: api/<PersonasController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MdpPersona>>>  Get()
        {
            var response = await _contextIntra.Set<MdpPersona>().Take(100).ToListAsync();
            return Ok(response);
        }

        // GET api/<PersonasController>/5
        [HttpGet("{nro_documento}")]
        public async Task<ActionResult<IEnumerable<MdpPersona>>> Get(string nro_documento)
        {
            var response = await _contextIntra.Set<MdpPersona>().Where(x => x.NroDocumento == nro_documento).ToListAsync();
            return Ok(response);
        }


        // POST api/<PersonasController>
        [HttpPost]
        public async Task<ActionResult<string>> migracionPersona([FromBody] string nro_documento)
        {
            MdpPersona responseQuery = await _contextIntra.Set<MdpPersona>().Where(x => x.NroDocumento == nro_documento).FirstAsync();

            if (responseQuery == null)
            {
                return NotFound("La persona no existe en el contexto de origen.");
            }

            CusPersona nuevaPersonaAMigrar = (CusPersona) responseQuery;
            var responseMigration = await _contextCustomDB.Set<CusPersona>().AddAsync(nuevaPersonaAMigrar);
            _contextCustomDB.SaveChanges();

            return Ok("se ha registrado a la persona con exito.");
        }


    }
}
