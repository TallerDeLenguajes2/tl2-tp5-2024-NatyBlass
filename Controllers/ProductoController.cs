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

    [HttpPut("{id}")]
    public ActionResult ModificarProducto(int id, Producto prod)
    {
        repositorio.ModificarProducto(id, prod);
        return Ok();
    }

    [HttpGet]
    public ActionResult ListarProductos()
    {
        repositorio.ListarProductos();
        return Ok();
    }
}
