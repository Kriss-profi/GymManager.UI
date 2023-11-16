using GymManager.Application.Common.Interfaces;
using GymManager.Application.Dictionaries;
using MediatR;

namespace GymManager.Application.Contacts.Commands.SendContactEmail;

public class SendContactEmailCommandHandler : IRequestHandler<SendContactEmailCommand>
{
    private readonly IEmail email;
    private readonly IAppSettingsService appSettings;

    public SendContactEmailCommandHandler(
        IEmail email, 
        IAppSettingsService appSettings)
    {
        this.email = email;
        this.appSettings = appSettings;
    }


    public async Task<Unit> Handle(SendContactEmailCommand request, CancellationToken cancellationToken)
    {
        var body = $"Nazwa: {request.Name}.<br /><br />E-Mail nadawcy: {request.Email}.<br /><br />Tytuł Wiadomości: {request.Title}.<br /><br />Wiadomość: {request.Message}.<br /><br />Wysłano z GymManager. ";

        await this.email.SendAsync(
            $"Wiadomość z GymManager: {request.Title}",
            body,
            await this.appSettings.Get(SettingsDict.AdminEmail));

        return Unit.Value;
        // wysłać wiadomość email do admina
    }
}