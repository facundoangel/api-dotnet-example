using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.FeatureManagement.Mvc;
using test.auth;

namespace test.Controllers
{
    [FeatureGate("LoginController")]
    [Route("api/[controller]/")]
    [ApiController]
    public class LoginController(IOptions<JWTConfiguracion> jwtOptions) : ControllerBase
    {

        private readonly JWTConfiguracion jwtConfiguracion = jwtOptions.Value;

        [AllowAnonymous]
        [HttpGet("login")]
        public IActionResult login()
        {
       
            var token = JWTHandler.generateToken(jwtConfiguracion);
            JWTHandler.setTokenCookie(HttpContext,token,false,"session-id",30);



            return Ok(token);
        }
    }
}
