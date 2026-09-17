using System;
using System.Collections.Generic;

namespace ItensMercado.Models;

public partial class Produto
{
    public int ProdutoID { get; set; }

    public string NomeProduto { get; set; } = null!;

    public int Quantidade { get; set; }

    public bool FoiComprado { get; set; }
}
