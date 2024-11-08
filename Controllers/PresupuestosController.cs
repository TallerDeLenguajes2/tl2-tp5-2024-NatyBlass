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

    [HttpGet]
    public ActionResult ListarPresupuestos()
    {
        var presupuestos = repositorioPresupuesto.ListarPresupuesto();

        if (presupuestos != null)
        {
            return Ok(presupuestos);
        }
        else
        {
            return NotFound("No hay nada en la lista de Presupuestos");
        }
    }

    [HttpGet("{id}")]
    public ActionResult ObtenerPresupuestoPorId(int id)
    {
        var presup = repositorioPresupuesto.ObtenerPresupuestoPorId(id);

        if (presup != null)
        {
            return Ok(presup);
        }
        else
        {
            return NotFound("Presupuesto No Encontrado");
        }
    }

}