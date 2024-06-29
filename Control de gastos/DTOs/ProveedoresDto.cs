namespace Control_de_gastos.DTOs
{
    public class ProveedoresDto
    {

        public int IdProveedor { get; set; }

        public string Nombre { get; set; } = null!;

        public int Telefono { get; set; }

        public string Email { get; set; } = null!;

        public string Direccion { get; set; } = null!;

    }
}
