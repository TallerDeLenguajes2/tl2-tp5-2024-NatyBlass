using Microsoft.AspNetCore.Mvc;

namespace tl2_tp5_2024_NatyBlass.Controllers;

[ApiController]
[Route("[controller]")]

public class PresupuestosController : ControllerBase
{
    private readonly PresupuestoRepositorio repositorioPresupuesto = new PresupuestoRepositorio();
    private readonly ProductoRepositorio repositorioProducto = new ProductoRepositorio();

    [HttpPost]
    public ActionResult CrearPresupuesto([FromBody] Presupuesto presup)
    {
        repositorioPresupuesto.CrearPresupuesto(presup);
        return Ok("Presupuesto Creado Correctamente");
    }
}