using Final.Entidades;
using Final.Models;

namespace Final.Datos
{
    public class DatosEmpresa : DatosBase
    {
        public int GuardarEmpresa(EntEmpresa empresa)
        {

            // INSERTA EMPRESA 
            Empresa item = new Empresa();
            item.Nombre = empresa.Nombre;



            context.Empresa.Add(item);
            context.SaveChanges();

            return item.id_empresa;
        }
    }
}
