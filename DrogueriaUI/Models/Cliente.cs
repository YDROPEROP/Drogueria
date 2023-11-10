using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DrogueriaUI.Models;

public partial class Cliente
{
    public int Id { get; set; }
    [Required(ErrorMessage = "El campo {0} es requerido")]
    public string Identificacion { get; set; } = null!;
    [Required(ErrorMessage = "El campo {0} es requerido")]
    public string Nombre { get; set; } = null!;
    [Required(ErrorMessage = "El campo {0} es requerido")]
    public string Apellido { get; set; } = null!;
    [Required(ErrorMessage = "El campo {0} es requerido")]
    public int? IdCiudad { get; set; }
    [Required(ErrorMessage = "El campo {0} es requerido")]
    public virtual Ciudad? IdCiudadNavigation { get; set; }
}
