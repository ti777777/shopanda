import Vue from 'vue'
import VueRouter from 'vue-router'
import Home from '../views/Home.vue'

Vue.use(VueRouter)

const routes = [
  {
    path: '/',
    name: 'Home',
    component: Home
  },
  {
    path: '/Home',
    name: 'Home',
    component: Home
  },
  {
    path: '/category/EDITUSER',
    name: 'EDITUSER',
    component: () => import('../views/EDITUSERINFO.vue')
  },
  {
    path: '/category/EMP',
    name: 'EMP',
    component: () => import('../views/EMP.vue')
  },
  {
    path: '/category/DEPT',
    name: 'DEPT',
    component: () => import('../views/DEPT.vue')
  },
  {
    path: '/Login',
    name: 'Login',
    component: () => import('../views/Login.vue')
  },
  {
    path: '/category/PEC',
    name: 'PEC',
    component: () => import('../views/PEC.vue')
  },
  {
    path: '/category/COMMENT',
    name: 'COMMENT',
    component: () => import('../views/COMMENT.vue')
  },
  ]

const router = new VueRouter({
  mode: 'history',
  base: process.env.BASE_URL,
  routes
})

export default router
