using System;
using System.Collections.Generic;

namespace MVC_Biblioteca.Models;

public partial class Usuario
{
    public int UsuarioID { get; set; }

    public string Nome { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Senha { get; set; } = null!;
}
