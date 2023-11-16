using MediatR;
using Microsoft.Extensions.Logging;


namespace GymManager.Application.Common.Behaviours;

public class LoggingBehaviour<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse> where TRequest : IRequest<TResponse>
{
    private readonly ILogger<TRequest> logger;

    public LoggingBehaviour(ILogger<TRequest> logger)
    {
        this.logger = logger;
    }

    public async Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken, RequestHandlerDelegate<TResponse> next)
    {
        var requestName = typeof(TRequest).Name;

        this.logger.LogInformation($"Handling {requestName}");

        this.logger.LogInformation(">>> LOGOWANIE WSZYSTKIEGO  <<<  ---   GymManager Request: {@Name} {@Request}", requestName, request);

        var response = await next();

        this.logger.LogInformation($"Handled {typeof(TResponse).Name}");

        return response;
    }
}
