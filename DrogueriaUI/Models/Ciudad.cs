using System;
using System.Collections.Generic;

namespace DrogueriaUI.Models;

public partial class Ciudad
{
    public int Id { get; set; }

    public string Nomre { get; set; } = null!;

    public virtual ICollection<Cliente> Clientes { get; set; } = new List<Cliente>();
}
