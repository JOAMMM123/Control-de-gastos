using System;
using System.Collections.Generic;

namespace Control_de_gastos.Models;

public partial class Inventario
{
    public int IdMaterial { get; set; }

    public int Cantidad { get; set; }

    public decimal Precio { get; set; }

    public DateTime? FechaMovimiento { get; set; }

    public DateTime? FechaCaducidad { get; set; }
}
