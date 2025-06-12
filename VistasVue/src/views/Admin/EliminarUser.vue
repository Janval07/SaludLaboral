<template>
  <div class="bloque-titulo">
    <h1>Dar de Baja al Estudiante</h1>
  </div>
  <div class="centro">
    <br /><br />
    <form action="http://localhost:8080/Proyecto_SaludLaboral/ServletEliminarUsuario" method="post">
      <label for="id">ID del alumno:</label>
      <input type="number" id="id" name="id" required /><br /><br />

      <input type="submit" class="boton" value="Enviar" onclick="confirmarBaja();" />
      <input type="reset" value="Limpiar" class="boton" />
    </form>

    <br />
    <p><a href="../Admin/AdminUser.vue" class="regresar">Regresar</a></p>
  </div>
</template>

<script></script>
