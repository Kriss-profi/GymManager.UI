﻿using Microsoft.AspNetCore.Mvc;

namespace GymManager.UI.Controllers;

public class ClientController : BaseController
{
    public IActionResult Dashboard()
    {
        return View();
    }
    public IActionResult Client()
    {
        return View();
    }
    public IActionResult Clients()
    {
        return View();
    }
}
