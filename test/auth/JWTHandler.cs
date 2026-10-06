using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace test.auth
{
    public class JWTHandler
    {



        public static string generateToken(JWTConfiguracion tokenConfiguracion)
        {

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(tokenConfiguracion.SecretKey));

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                expires: DateTime.Now.AddMinutes(30),
                signingCredentials : creds

            );

            return new JwtSecurityTokenHandler().WriteToken(token);

        }

        public static void setTokenCookie(HttpContext contexto, string token, Boolean dominioRestringido, string nombreCookie, int tokenExpiracion)
        {
            contexto.Response.Cookies.Append(nombreCookie, token, new CookieOptions
            {
                HttpOnly = true,
                Secure = true,
                SameSite = SameSiteMode.None,
                Expires = DateTime.Now.AddMinutes(tokenExpiracion),
                Path = "/",
                Domain = dominioRestringido ? "unlam.edu.ar" : null
            });



        }
    }
}
