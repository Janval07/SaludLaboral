using Final.Datos;
using Final.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace Final.Controllers
{
    public class UsuarioController
    {
        [HttpPost]
        [Route("api/AgregarUsuario")]
        public IActionResult AgregarUsuario([FromBody] EntEstudiante Captura)
        {
           return null;
           
        }
        [HttpPost]
        [Route("api/EliminarUsuario")]
        public IActionResult EliminarUsuario([FromBody] EntEstudiante Captura)
        {
            return null;

        }
        [HttpPost]
        [Route("api/ModificarUsuario")]
        public IActionResult ModificarUsuario([FromBody] EntEstudiante Captura)
        {
            return null;

        }
        [HttpPost]
        [Route("api/ConsultarUsuario")]
        public IActionResult ConsultarUsuario([FromBody] EntEstudiante Captura)
        {
            return null;

        }
    }
}
