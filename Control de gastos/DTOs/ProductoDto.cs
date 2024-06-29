namespace Control_de_gastos.DTOs
{
    public class ProductoDto
    {
        public int IdProducto { get; set; }

        public string Nombre { get; set; } = null!;

        public int IdProveedor { get; set; }
    }
}
