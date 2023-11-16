using MediatR;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace GymManager.Application.Common.Behaviours;

public class PerformanceBehaviour<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse> where TRequest : IRequest<TResponse>
{
    private readonly ILogger<TRequest> logger;
    private readonly Stopwatch timer;

    public PerformanceBehaviour(ILogger<TRequest> logger)
    {
        this.timer = new Stopwatch();
        this.logger = logger;
    }

    public async Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken, RequestHandlerDelegate<TResponse> next)
    {
        this.timer.Start();

        var response = await next();

        this.timer.Stop();

        var elapsedMilliseconds = this.timer.ElapsedMilliseconds;

        if(elapsedMilliseconds > 500)
        {
            this.logger.LogInformation(">>> Test Wydajności  <<< ----  Request {@Name} - {@Request}; Wywołany przez Użytkownika UserData trawał zbyt długo  bo aż : {@ElapsedMilliseconds} nilliseconds", 
                typeof(TRequest).Name, request, elapsedMilliseconds);    
        }

        return response;
    }
}
