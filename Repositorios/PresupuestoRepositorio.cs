using Microsoft.Data.Sqlite;
using System.Collections.Generic;

public class PresupuestoRepositorio
{
    private string cadenaDeConexion = "Data Source=Tienda.db;Cache=Shared";

    public void CrearPresupuesto(Presupuesto presup)
    {
        using (var connection = new SqliteConnection(cadenaDeConexion))
        {
            string consulta = "INSERT INTO Presupuestos (NombreDestinatario, FechaCreacion) VALUES (@NombreDestinatario, @FechaCreacion);";
            var command = new SqliteCommand(consulta, connection);
            command.Parameters.AddWithValue("@NombreDestinatario", presup.NombreDestinatario);
            command.Parameters.AddWithValue("@FechaCreacion", presup.FechaCreacion);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}