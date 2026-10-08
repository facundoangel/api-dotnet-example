using DTO.Persona;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.FeatureManagement.Mvc;
using Modelo;
using Persistencia.Data;
using System.Threading.Tasks;
using test.auth;

namespace test.Controllers
{
    [FeatureGate("LoginController")]
    [Route("api/[controller]/")]
    [ApiController]
    public class LoginController(IOptions<JWTConfiguracion> jwtOptions, CustomDBContext contextCustomDB, UserManager<CusPersona> userManager) : ControllerBase
    {

        private readonly JWTConfiguracion jwtConfiguracion = jwtOptions.Value;

        [AllowAnonymous]
        [HttpPost("login")]
        public async Task<IActionResult> login([FromBody] loginPersonaDTO datosLogin)
        {

            var usuario = await contextCustomDB.Set<CusPersona>().Where(x => x.nro_documento == datosLogin.Identifier).FirstOrDefaultAsync();
          

            if (usuario == null)
                return Ok("No se encontro al usuario");

            if(await userManager.CheckPasswordAsync(usuario, datosLogin.Password))
            {

                var token = JWTHandler.generateToken(jwtConfiguracion);
                JWTHandler.setTokenCookie(HttpContext,token,false,"session-id",30);



                return Ok(token);

            }

            return Ok("Contraseña incorrecta");
        }
    }
}
