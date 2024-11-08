using Microsoft.Data.Sqlite;


public class ProductoRepositorio
{
    private string cadenaDeConexion = "Data Source=Tienda.db;Cache=Shared";

    public void CrearProducto (Producto prod)
    {
        using (var connection = new SqliteConnection(cadenaDeConexion))
        {
            string consulta = "INSERT INTO Productos (Descripcion, Precio) VALUES (@Descripcion, @Precio);";
            var command = new SqliteCommand(consulta, connection);
            command.Parameters.AddWithValue("@Descripcion", prod.Descripcion);
            command.Parameters.AddWithValue("@Precio", prod.Precio);
            
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}