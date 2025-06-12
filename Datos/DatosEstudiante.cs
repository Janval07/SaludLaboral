using Final.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Final.Datos
{
    public class DatosEstudiante : DatosBase
    {
        public EntEstudiante ValidaUsuario(EntEstudiante Estudiante)
        {
            var data = context.Estudiante
                .AsNoTracking()
                .Where(w => w.id_estudiante == Estudiante.Id_estudiante && w.Contrasena == Estudiante.Contrasena)
                .FirstOrDefault();
            
            //Convierte los resultados de base de datos a un objeto igual a la tabla
            EntEstudiante datosEstudiantes = mapperEntity.ToEntity<EntEstudiante>(data);

            return datosEstudiantes;
        }
    }
}
