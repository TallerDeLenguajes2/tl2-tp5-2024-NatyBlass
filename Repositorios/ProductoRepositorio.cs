using System.Data.SQLite;

public class ProductoRepositorio
{
    private string cadenaDeConexion = "Data Source=Tienda.db;Cache=Shared";

    public void CrearProducto (Producto prod)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
    }
}