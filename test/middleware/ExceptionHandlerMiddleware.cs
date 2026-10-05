using System.Text.Json;
using DTO;


namespace test.middleware
{
    public class ExceptionHandlerMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly IWebHostEnvironment _env;


        public ExceptionHandlerMiddleware(RequestDelegate next, IWebHostEnvironment env)
        {
            _next = next;
            _env = env;
        }


        public async Task InvokeAsync(HttpContext http)
        {
            try
            {
                await _next(http);

            }catch (Exception ex)
            {
                await handleExceptionAsync(ex, http);
            }
        }


        private async Task handleExceptionAsync(Exception ex, HttpContext http)
        {
            var statusCode = ex switch
            {
                KeyNotFoundException => StatusCodes.Status404NotFound,
                ArgumentException => StatusCodes.Status400BadRequest,
                _ => StatusCodes.Status500InternalServerError
            };

            var response = new ErrorOperacion
            {
                StatusCode = statusCode,
                Message = statusCode == 500 && !_env.IsDevelopment() ? "Ha ocurrido un error" : ex.Message,
            };


            await http.Response.WriteAsync(JsonSerializer.Serialize(response));
        }
    }
}
