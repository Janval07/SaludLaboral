using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Final.Models;

public partial class Pregunta
{
    [Key]
    public int id_pregunta { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Descripcion { get; set; }

    [InverseProperty("id_preguntaNavigation")]
    public virtual ICollection<Formulario> Formulario { get; set; } = new List<Formulario>();
}
