public class PresupuestoDetalle
{
    private Producto prod;
    private int cantidad;

    public Producto Prod { get => producto; set => producto = value; }
    public int Cantidad { get => cantidad; set => cantidad = value; }

    public PresupuestoDetalle(Producto prod, int cantidad)
    {
        prod = prod;
        cantidad = cantidad;
    }
}