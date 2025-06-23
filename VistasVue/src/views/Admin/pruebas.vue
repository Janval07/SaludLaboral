<template>
  <div class="container mx-auto p-4">
    <h2 class="text-xl font-bold mb-4">Cuestionario</h2>

    <div v-if="Preguntas" class="bg-white p-4 shadow rounded">
      <p class="font-semibold mb-4">{{ Preguntas[idPregunta - 1].categoriaDescripcion }}</p>
      <p class="mb-4">Pregunta {{ idPregunta }} de {{ Preguntas.length }} :</p>
      <p class="font-semibold mb-4">{{ Preguntas[idPregunta - 1].preguntaDescripcion }}</p>

      <div class="flex flex-col gap-2 mb-4">
        <label v-for="(option, idx) in Opciones" :key="idx">
          <div v-if="option.idPregunta == idPregunta">
            <div v-if="option.opcion == 'Booleano'">
              <div class="form-check">
                <input
                  v-model="RespuestaSi"
                  class="form-check-input"
                  type="radio"
                  name="radioDefault"
                  id="radioDefault1"
                />
                <label class="form-check-label" for="radioDefault1"> Si </label>
              </div>
              <div class="form-check">
                <input
                  v-model="RespuestaNo"
                  class="form-check-input"
                  type="radio"
                  name="radioDefault"
                  id="radioDefault2"
                />
                <label class="form-check-label" for="radioDefault2"> No </label>
              </div>
            </div>
            <div v-else-if="option.opcion == 'texto'">
              <div class="campo">
                <label for="usuario">Respuesta</label>
                <input
                  type="text"
                  id="usuario"
                  name="usuario"
                  class="input-usuario"
                  v-model="Respuesta"
                />
              </div>
            </div>
            <div v-else>
              <div class="form-check me-3">
                <input
                  v-model="Respuesta"
                  class="form-check-input"
                  type="radio"
                  name="radioDefault"
                  id="radioDefault1"
                />
                <label class="form-check-label" for="radioDefault1"> {{ option.opcion }} </label>
              </div>
            </div>
          </div>
        </label>
      </div>

      <div class="flex justify-between">
        <button
          @click="prevQuestion"
          :disabled="idPregunta === 0"
          class="bg-gray-400 px-4 py-2 rounded disabled:opacity-50"
        >
          Anterior
        </button>
        <button
          @click="nextQuestion"
          :disabled="Preguntas != null && idPregunta === Preguntas.length"
          class="bg-blue-500 px-4 py-2 rounded disabled:opacity-50"
        >
          Siguiente
        </button>
      </div>
    </div>

    <button
      @click="submitAnswers"
      v-if="Preguntas != null && idPregunta == Preguntas.length"
      class="bg-blue-500 px-4 py-2 rounded disabled:opacity-50 center"
    >
      Enviar Formulario
    </button>
  </div>
</template>

<script>
export default {
  data() {
    return {
      idPregunta: 1,
      questions: [],
      answers: [],
      CapturaRespuestas: null,
      Preguntas: null,
      Opciones: null,
      Respuesta: null,
      RespuestaSi: null,
      RespuestaNo: null,
    }
  },
  created() {},
  methods: {
    async nextQuestion() {
      if (this.RespuestaSi == 'on') {
        this.Respuesta = 'Si'
      }
      if (this.RespuestaNo == 'on') {
        this.Respuesta = 'No'
      }

      var CapRes = {
        Id_formulario: 0,
        Folio: this.CapturaRespuestas.formulario[0].folio,
        Fecha: this.CapturaRespuestas.formulario[0].fecha,
        Respuesta: this.Respuesta,
        Id_trabajador: this.CapturaRespuestas.trabajador.id_trabajador,
        Id_pregunta: this.idPregunta,
      }

      const res = await this.$axios.post('https://localhost:44338/api/GuardarRespuestas', CapRes)

      if (res.data > 0) {
        if (this.idPregunta <= this.Preguntas.length - 1) {
          this.idPregunta++

          //Limpiar respuestas
          this.RespuestaSi = null
          this.RespuestaNo = null
          this.Respuesta = null
        }
      }
    },
    prevQuestion() {
      if (this.idPregunta > 0) {
        this.idPregunta--
      }
    },
    submitAnswers() {
      if (this.RespuestaSi == 'on') {
        this.Respuesta = 'Si'
      }
      if (this.RespuestaNo == 'on') {
        this.Respuesta = 'No'
      }
      if (this.Respuesta == null) {
        alert('Responde la ultima pregunta!')
        return
      }
      alert('¡Respuestas enviadas!')
      //Borrar datos de local

      this.nextQuestion()
      localStorage.removeItem('DatosFormulario')
      this.$router.push('/')
    },
  },

  beforeCreate() {
    var session = JSON.parse(localStorage.getItem('DatosFormulario'))

    if (session == null) {
      this.$router.push('/')
    }
  },

  async mounted() {
    // Recuperar los datos del formulario
    //console.log(this.Preguntas)
    //Obtener Preguntas
    this.CapturaRespuestas = JSON.parse(localStorage.getItem('DatosFormulario'))

    const res = await this.$axios.post(
      'https://localhost:44338/api/ObtenerPreguntas',
      this.CapturaRespuestas,
    )
    //console.log(res)
    // Se asigna resultado a variable pregunta
    this.Preguntas = res.data

    //Consultar Opciones
    const op = await this.$axios.get('https://localhost:44338/api/ObtenerOpciones')
    // Se asigna resultado a variable opciones
    this.Opciones = op.data

    //console.log(this.Opciones)
  },
}
</script>

<style>
body {
  font-family: 'Segoe UI', sans-serif;
  background-color: #f3f4f6;
}
</style>
