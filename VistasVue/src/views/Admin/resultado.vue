<template>
  <nav class="navbar sticky-top navbar-expand-sm navbar-white">
    <div class="container-fluid">
      <div class="navbar-center">
        <a class="navbar-brand ms-2" href="#">
          <span class="web-color ms-2">Información de Trabajadores</span>
        </a>
      </div>
      <button
        class="navbar-toggler"
        type="button"
        data-bs-toggle="collapse"
        data-bs-target="#mynavbar"
      >
        <span class="navbar-toggler-icon"></span>
      </button>
    </div>
  </nav>

  <!-- DataGrid (Tabla) -->
  <table border="1" style="margin-top: 20px; width: 100%">
    <thead>
      <tr>
        <th>#</th>
        <th>Nombre</th>
        <th>apellido</th>
        <th>edad</th>
        <th>sexo</th>
        <th>estado_Civil</th>
        <th>escolaridad</th>
        <th>% Valoracion</th>
        <th>Valoracion</th>
      </tr>
    </thead>
    <tbody>
      <tr v-for="(trabajador, index) in trabajadores" :key="index">
        <td>{{ index + 1 }}</td>
        <td>{{ trabajador.nombre }}</td>
        <td>{{ trabajador.apellidos }}</td>
        <td>{{ trabajador.edad }}</td>
        <td>{{ trabajador.sexo }}</td>
        <td>{{ trabajador.estado_Civil }}</td>
        <td>{{ trabajador.escolaridad }}</td>
        <td>{{ trabajador.porcentajeValoracion }} %</td>
        <td>{{ trabajador.resultadoValoracion }}</td>
        <!-- <td>
          <button @click="eliminarUsuario(index)">Eliminar</button>
        </td> -->
      </tr>
    </tbody>
  </table>
</template>
<script>
export default {
  name: 'App',
  data() {
    return {
      trabajadores: [],
    }
  },
  methods: {},
  async mounted() {
    const res = await this.$axios.post('https://localhost:44338/api/ConsultarTrabajador', {})
    this.trabajadores = res.data
    console.log(res)
  },
}
</script>
