<template>
  <div class="container mx-auto p-4">
    <h2 class="text-xl font-bold mb-4">Cuestionario</h2>

    <div class="bg-white p-4 shadow rounded">
      <p class="mb-4">Pregunta {{ currentIndex + 1 }} de {{ questions.length }}:</p>
      <p class="font-semibold mb-4">{{ questions[currentIndex].text }}</p>

      <div class="flex flex-col gap-2 mb-4">
        <label v-for="(option, idx) in questions[currentIndex].options" :key="idx">
          <input
            type="radio"
            :name="'question-' + currentIndex"
            :value="option"
            v-model="answers[currentIndex]"
          />
          {{ option }}
        </label>
      </div>

      <div class="flex justify-between">
        <button
          @click="prevQuestion"
          :disabled="currentIndex === 0"
          class="bg-gray-400 px-4 py-2 rounded text-white disabled:opacity-50"
        >
          Anterior
        </button>
        <button
          @click="nextQuestion"
          :disabled="currentIndex === questions.length - 1"
          class="bg-blue-500 px-4 py-2 rounded text-white disabled:opacity-50"
        >
          Siguiente
        </button>
      </div>
    </div>

    <div class="mt-6 text-center" v-if="currentIndex === questions.length - 1">
      <button @click="submitAnswers" class="bg-green-600 px-4 py-2 rounded text-white">
        Enviar respuestas
      </button>
    </div>
  </div>
</template>

<script>
export default {
  data() {
    return {
      currentIndex: 0,
      questions: [],
      answers: [],
    }
  },
  created() {
    // Generar 50 preguntas de ejemplo
    for (let i = 1; i <= 50; i++) {
      this.questions.push({
        text: `¿Pregunta número ${i}?`,
        options: ['Opción A', 'Opción B', 'Opción C', 'Opción D'],
      })
    }

    // Inicializa el array de respuestas vacío
    this.answers = Array(this.questions.length).fill(null)
  },
  methods: {
    nextQuestion() {
      if (this.currentIndex < this.questions.length - 1) {
        this.currentIndex++
      }
    },
    prevQuestion() {
      if (this.currentIndex > 0) {
        this.currentIndex--
      }
    },
    submitAnswers() {
      console.log('Respuestas enviadas:', this.answers)
      alert('¡Respuestas enviadas! Revisa la consola.')
    },
  },
}
</script>

<style>
body {
  font-family: 'Segoe UI', sans-serif;
  background-color: #f3f4f6;
}
</style>
