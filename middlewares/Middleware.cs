namespace support_task4.middlewares
{
    public class Middleware
    {
        private RequestDelegate _next;
        public static List<String>Paths = new List<String>();

        public Middleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task Invoke(HttpContext context) {
            Paths.Add(context.Request.Path);
            await _next(context);
        }
     
       
    }
}
