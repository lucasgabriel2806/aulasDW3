using ExercicioClinica.Models;
using Microsoft.AspNetCore.Mvc;

public class ClinicaController : Controller
{
    private readonly MongoService _service;

    public ClinicaController(MongoService service)
    {
        _service = service;
    }

    public IActionResult Index()
    {
        var lista = _service.Get();
        return View(lista);
    }

    public IActionResult Nova()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Nova(Clinica c)
    {
        c.Alarme = "Desligado";
        _service.Create(c);
        return RedirectToAction("Index");
    }

    public IActionResult Toggle(string id)
    {
        _service.ToggleAlarme(id);
        return RedirectToAction("Index");
    }
}