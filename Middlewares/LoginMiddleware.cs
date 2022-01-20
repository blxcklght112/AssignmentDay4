using System.Diagnostics;

namespace CS_DotnetCoreDay4.Middlewares
{
    public class LoginMiddleware
    {
        private readonly RequestDelegate _next;
        public LoginMiddleware(RequestDelegate next)
        {
            this._next = next;
        }
        public async Task Invoke(HttpContext context)
        {
            using var buffer = new MemoryStream();
            var request = context.Request;
            var response = context.Response;
            var stream = response.Body;
            response.Body = buffer;
            await _next(context);

            Debug.WriteLine($"Request content type: Scheme: {request.Scheme}, Host: {request.Host}, Path: {request.Path}, QueryString: {request.QueryString}, Body: {request.Body}");
            
            buffer.Position = 0;
            await buffer.CopyToAsync(stream);
        }
    }
}