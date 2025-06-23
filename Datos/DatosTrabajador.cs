using Final.Entidades;
using Final.Models;

namespace Final.Datos
{
    public class DatosTrabajador : DatosBase
    {
        public int GuardarTrabajador(EntTrabajador trabajador) 
        {

            // Convierte tu objeto EntTrabajador a la entidad real de la base de datos si es necesario
            var entity = mapperEntity.ToEntity<Trabajador>(trabajador);

            context.Trabajador.Add(entity);
            context.SaveChanges();

            //Regresa el id del trabajador recien insertado
            return entity.id_trabajador;
        }
    }
}
