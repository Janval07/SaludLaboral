<template>
  <div class="bloque-titulo">
    <h1>Consultar datos del Estudiante</h1>
  </div>
  <div class="centro">
    <br /><br />
    <form
      action="http://localhost:8080/Proyecto_SaludLaboral/ServletConsultarUsuario"
      method="post"
    >
      <p class="d-flex justify-content-center">
        Llene el campo del atributo que quiera con lo que desee consultar:
      </p>
      <br />

      <label for="id">ID: </label>
      <input type="number" id="id" name="id" /><br /><br />

      <label for="nombre">Nombre:</label>
      <input type="text" id="nombre" name="nombre" /><br /><br />

      <label for="apellidos">Apellidos:</label>
      <input type="text" id="apellidos" name="apellidos" /><br /><br />

      <label for="grupo">Grupo:</label>
      <input type="text" id="grupo" name="grupo" /><br /><br />

      <label for="password">Contrase&ntilde;a:</label>
      <input type="text" id="password" name="password" /><br /><br />

      <p class="d-flex justify-content-center">
        Si desea ver todos los estudiantes registrados s&oacute;lo presione Enviar:
      </p>
      <br />

      <input type="submit" class="boton" value="Enviar" />
      <input type="reset" value="Limpiar" class="boton" />
    </form>
    <br />
    <p><a href="../Admin/AdminUser.vue" class="regresar">Regresar</a></p>
  </div>
</template>

<script></script>
