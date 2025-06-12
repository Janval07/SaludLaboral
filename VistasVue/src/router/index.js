import { createRouter, createWebHistory } from 'vue-router'
import Login from '@/views/Login.vue'

import InicioAdmin from '@/views/Admin/InicioAdmin.vue'
import guia from '@/views/Admin/guia.vue'
import formulario from '@/views/Admin/formulario.vue'
import ayuda from '@/views/Admin/ayuda.vue'
import AdminUser from '@/views/Admin/AdminUser.vue'
import AgregarUser from '@/views/Admin/AgregarUser.vue'
import ConsultaUser from '@/views/Admin/ConsultaUser.vue'
import EliminarUser from '@/views/Admin/EliminarUser.vue'
import Informe from '@/views/Admin/Informe.vue'
import ModificarUser from '@/views/Admin/ModificarUser.vue'
import Resultados from '@/views/Admin/Resultados.vue'
import InicioAlumno from '@/views/User/InicioAlumno.vue'
import pruebas from '@/views/Admin/pruebas.vue'

const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: [
    {
      path: '/',
      name: 'login',
      component: Login,
    },
    {
      path: '/pruebas',
      name: 'pruebas',
      component: pruebas,
    },
    {
      path: '/inicioadmin',
      name: 'inicioadmin',
      component: InicioAdmin,
    },
    {
      path: '/guia',
      name: 'guia',
      component: guia,
    },
    {
      path: '/formulario',
      name: 'formulario',
      component: formulario,
    },
    {
      path: '/ayuda',
      name: 'ayuda',
      component: ayuda,
    },
    {
      path: '/adminuser',
      name: 'adminuser',
      component: AdminUser,
    },
    {
      path: '/agregaruser',
      name: 'agregaruser',
      component: AgregarUser,
    },
    {
      path: '/consultauser',
      name: 'consultauser',
      component: ConsultaUser,
    },
    {
      path: '/eliminaruser',
      name: 'eliminaruser',
      component: EliminarUser,
    },
    {
      path: '/informe',
      name: 'informe',
      component: Informe,
    },
    {
      path: '/modificaruser',
      name: 'modificaruser',
      component: ModificarUser,
    },
    {
      path: '/resultados',
      name: 'resultados',
      component: Resultados,
    },
    {
      path: '/inicioalumno',
      name: 'inicioalumno',
      component: InicioAlumno,
    },
  ],
})

export default router
