using System;
using System.Collections.Generic;

namespace Control_de_gastos.Models;

public partial class Producto
{
    public int IdProducto { get; set; }

    public string Nombre { get; set; } = null!;

    public int IdProveedor { get; set; }

    public virtual Proveedore IdProveedorNavigation { get; set; } = null!;
}
