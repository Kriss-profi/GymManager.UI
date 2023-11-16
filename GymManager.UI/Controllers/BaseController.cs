using GymManager.Application.Common.Exceptions;
using GymManager.UI.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace GymManager.UI.Controllers;

public abstract class BaseController : Controller
{
    private ISender _mediatr;
    protected ISender Mediator => _mediatr ??= HttpContext.RequestServices.GetService<ISender>();

    protected async Task<MediatorValidateResponse<T>> MediatorSendValidate<T>(IRequest<T> request)
    {
        var response = new MediatorValidateResponse<T> { IsValid = false };
        try
        {

            if (ModelState.IsValid)
            {
                response.Model =  await Mediator.Send(request);
                response.IsValid = true;
                return response;
            }
        }
        catch (ValidationException exception)
        {
            foreach (var error in exception.Errors)
            {
                ModelState.AddModelError(error.Key, string.Join(". ", error.Value));
            }
        }

        return response;
    }
}
