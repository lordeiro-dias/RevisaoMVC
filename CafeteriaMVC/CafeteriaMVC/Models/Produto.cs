using System;
using System.Collections.Generic;

namespace CafeteriaMVC.Models;

public partial class Produto
{
    public int ProdutoID { get; set; }

    public string? NomeProduto { get; set; }

    public decimal? Preco { get; set; }

    public string? Descricao { get; set; }
}
