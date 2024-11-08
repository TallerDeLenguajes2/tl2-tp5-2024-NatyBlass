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
    public ActionResult CrearProducto([FromBody] Producto prod)
    {
        repositorio.CrearProducto(prod);
        return Ok();
    }

    [HttpPut("{id}")]
    public ActionResult ModificarProducto(int id, Producto prod)
    {
        repositorio.ModificarProducto(id, prod);
        return Ok("Producto Modificado Correctamente");
    }

    [HttpGet]
    public ActionResult ListarProductos()
    {
        var listaProductos = repositorio.ListarProductos();
        
        if (listaProductos != null)
        {
            return Ok("Productos Listados");
        }
        else
        {
            return NotFound("No hay Lista de Productos");
        }
    }

    [HttpGet("{id}")]
    public ActionResult ObtenerProductoPorId(int id)
    {
        var producto = repositorio.ObtenerProductoPorId(id);

        if(producto != null)
        {
            return Ok("Producto Encontrado");
        }
        else
        {
            return NotFound("Producto no Encontrado");
        }
    }

    [HttpDelete("{id}")]
    public ActionResult EliminarProducto(int id)
    {
        repositorio.EliminarProducto(id);
        return Ok("Producto Eliminado Correctamente");
    }
}
