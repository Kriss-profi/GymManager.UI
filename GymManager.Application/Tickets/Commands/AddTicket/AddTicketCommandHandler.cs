using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.Application.Tickets.Commands.AddTicket
{
    internal class AddTicketCommandHandler : IRequestHandler<AddTicketCommand>
    {
        private readonly ILogger logger;

        public AddTicketCommandHandler(ILogger<AddTicketCommandHandler> logger)
        {
            this.logger = logger;
        }
        public async Task<Unit> Handle(AddTicketCommand request, CancellationToken cancellationToken)
        {
            //var ticket = new Tickets();
            //ticket.Name = request.Name;
            this.logger.LogInformation("AddTicketCommandHandler - blablanla");
            return Unit.Value;
        }
    }
}
