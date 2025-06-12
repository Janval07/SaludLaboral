<template>
  <div class="bloque-titulo">
    <h1>Dar de alta a Estudiante</h1>
  </div>
  <div class="centro">
    <br /><br />
    <form action="http://localhost:8080/Proyecto_SaludLaboral/ServletInsertarUser" method="post">
      <label for="id">ID del alumno:</label>
      <input type="number" id="id" name="id" required /><br /><br />

      <label for="nombre">Nombre:</label>
      <input type="text" id="nombre" name="nombre" required /><br /><br />

      <label for="apellidos">Apellidos:</label>
      <input type="text" id="apellidos" name="apellidos" required /><br /><br />

      <label for="grupo">Grupo:</label>
      <input type="text" id="grupo" name="grupo" required /><br /><br />

      <label for="password">Contrase&ntilde;a:</label>
      <input type="text" id="password" name="password" required /><br /><br />

      <input type="submit" class="boton" value="Enviar" />

      <input type="reset" value="Limpiar" class="boton" />
    </form>

    <br />
    <p><a href="../Admin/AdminUser.vue" class="regresar">Regresar</a></p>
  </div>
</template>

<script></script>
