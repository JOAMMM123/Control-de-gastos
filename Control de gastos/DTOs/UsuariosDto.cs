﻿namespace Control_de_gastos.DTOs
{
    public class UsuariosDto
    {
        public int IdUsuario { get; set; }

        public string Nombre { get; set; } = null!;

        public string Apellido { get; set; } = null!;

        public string Correo { get; set; } = null!;

        public string Contraseña { get; set; } = null!;
    }
}
