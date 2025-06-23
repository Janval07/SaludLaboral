namespace Final.Entidades
{
    public class EntTrabajador
    {
        //  [id_trabajador]
        //,[Nombre]
        //,[Apellidos]
        //,[Edad]
        //,[Sexo]
        //,[Estado_Civil]
        //,[Escolaridad]
        //,[id_empresa]

        public int? Id_trabajador { get; set; }

        public string? Nombre { get; set; }
        public string? Apellidos { get; set; }
        public int? Edad { get; set; }
        public string? Sexo { get; set; }
        public string? Estado_Civil { get; set; }
        public string? Escolaridad { get; set; }
        public int? Id_empresa { get; set; }

    }
}
