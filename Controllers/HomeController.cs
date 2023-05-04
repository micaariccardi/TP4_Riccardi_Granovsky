using Microsoft.AspNetCore.Mvc;

namespace TPBase.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewBag.IndumentariaEquipos = Equipos.IndumentariaEquipos;
        return View(Index);
    }

    public IActionResult SelectIndumentaria()
    {
        ViewBag.medias = Equipos.listaMedias;
        ViewBag.pantalones = Equipos.listaPantalones;
        ViewBag.camisetas = Equipos.listaCamisetas;
        return View(SelectIndumentaria);
    }
    public IActionResult GuardarIndumentaria (int equipo=-1, int media=-1, int pantalon=-1, int remera=-1)
    {
        if(equipo == -1 || media == -1 || pantalon == -1 || remera == -1)
        {
            ViewBag.mensajeError="No seleccionaste todos los datos requeridos.";
            return View(SelectIndumentaria);
        }
        else
        {
            Indumentaria x = new Indumentaria(Equipos.listaMedias[media], Equipos.listaPantalones[pantalon], Equipos.listaCamisetas[remera]);
            Equipos.IngresarIndumentaria(Equipos.listaEquipos[equipo], x);
        }
        return View(Index);
    }
}
