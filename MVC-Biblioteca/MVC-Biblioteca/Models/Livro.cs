using System;
using System.Collections.Generic;

namespace MVC_Biblioteca.Models;

public partial class Livro
{
    public string Titulo { get; set; } = null!;

    public string Autor { get; set; } = null!;

    public DateTime DataLancamento { get; set; }

    public string Descricao { get; set; } = null!;

    public byte[]? Imagem { get; set; }
}
