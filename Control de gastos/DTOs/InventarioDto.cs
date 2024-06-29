namespace Control_de_gastos.DTOs
{
    public class InventarioDto
    {
        public int IdMaterial { get; set; }

        public int Cantidad { get; set; }

        public decimal Precio { get; set; }

        public DateTime? FechaMovimiento { get; set; }

        public DateTime? FechaCaducidad { get; set; }
    }
}