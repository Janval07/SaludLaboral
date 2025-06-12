<template>
  <div class="bloque-titulo">
    <h1>Cambiar datos del Estudiante</h1>
  </div>
  <div class="centro">
    <br /><br />
    <form action="http://localhost:8080/Proyecto_SaludLaboral/ServletCambiarUsuario" method="post">
      <label for="idActual">ID Actual del alumno:</label>
      <input type="number" id="idActual" name="idActual" required /><br /><br />

      <p class="d-flex justify-content-center">
        Llene el campo que desee modificar con los cambios que quiere:
      </p>
      <br />

      <label for="idNuevo">Nuevo ID del alumno:</label>
      <input type="number" id="idNuevo" name="idNuevo" /><br /><br />

      <label for="nombre">Nombre:</label>
      <input type="text" id="nombre" name="nombre" /><br /><br />

      <label for="apellidos">Apellidos:</label>
      <input type="text" id="apellidos" name="apellidos" /><br /><br />

      <label for="grupo">Grupo:</label>
      <input type="text" id="grupo" name="grupo" /><br /><br />

      <label for="password">Contrase&ntilde;a:</label>
      <input type="text" id="password" name="password" /><br /><br />

      <input type="submit" class="boton" value="Enviar" onclick="confirmarCambio();" />
      <input type="reset" value="Limpiar" class="boton" />
    </form>

    <br />
    <p><a href="../Admin/AdminUser.vue" class="regresar">Regresar</a></p>
  </div>
</template>

<script></script>
