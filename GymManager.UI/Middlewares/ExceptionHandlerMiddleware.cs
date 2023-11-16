using System.Net;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace GymManager.UI.Middlewares;

public class ExceptionHandlerMiddleware
{
    private readonly RequestDelegate next;
    private readonly ILogger logger;

    public ExceptionHandlerMiddleware(
        RequestDelegate next,
        ILogger<ExceptionHandlerMiddleware> logger)
    {
        this.next = next;
        this.logger = logger;
    }

    public async Task Invoke(HttpContext context)
    {
        try
        {
            await this.next.Invoke(context);
        }
        catch (Exception exception)
        {
            this.logger.LogError(exception, "GymManager Request: Nieobsłużony wyjątek - request {Name}", context.Request.Path);

            await HandleExceptionAsync(context, exception).ConfigureAwait(false);
        }
    }

    private Task HandleExceptionAsync(HttpContext context, Exception exception)
    {
        context.Response.ContentType = "application/json";
        int statusCode = (int) HttpStatusCode.InternalServerError;
        var result = JsonConvert.SerializeObject(new
            {
            StatusCode = statusCode,
            ErrorMessage = exception.Message
        });

        context.Response.Redirect($"{context.Request.Scheme}://{context.Request.Host}/Error");
        return context.Response.WriteAsync( result );
    }
}
