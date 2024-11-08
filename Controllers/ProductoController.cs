using Microsoft.AspNetCore.Mvc;

namespace tl2_tp5_2024_NatyBlass.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductoController : ControllerBase
{
    private readonly ProductoRepositorio repositorio;

    public ProductoController()
    {
        repositorio = new ProductoRepositorio();
    }

    [HttpPost]
    public ActionResult CrearProducto(Producto prod)
    {
        repositorio.CrearProducto(prod);
        return Ok();
    }
}
