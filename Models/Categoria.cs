using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Final.Models;

public partial class Categoria
{
    [Key]
    public int id_categoria { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Descripcion { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? Valoracion { get; set; }

    [InverseProperty("id_categoriaNavigation")]
    public virtual ICollection<Formulario> Formulario { get; set; } = new List<Formulario>();
}
