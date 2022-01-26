import Vue from 'vue'
import VueRouter from 'vue-router'
import Home from '../views/HOME/Home.vue'

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
    path: '/Login',
    name: 'Login',
    component: () => import('../views/LOGIN/Login.vue')
  },
  {
    path: '/Register',
    name: 'Register',
    component: () => import('../views/LOGIN/Register.vue')
  },
  {
    path: '/category',
    name: 'CATEGORY',
    component: () => import('../views/CATEGORY/CATEGORY.vue'),
    children: [
      {
        path: 'COMMENT',
        name: 'COMMENT',
        component: () => import('../views/COMMENT/COMMENT.vue')
      },
      {
        path: 'Setting',
        name: 'Setting',
        component: () => import('../views/SETTING/Setting.vue')
      },
      {
        path: 'EDITUSER',
        name: 'EDITUSER',
        component: () => import('../views/USERINFO/EDITUSERINFO.vue')
      },
      {
        path: 'PEC',
        name: 'PEC',
        component: () => import('../views/PEC/PEC.vue')
      },
      {
        path: 'DEPT',
        name: 'DEPT',
        component: () => import('../views/DEPT/DEPT.vue')
      },
      {
        path: 'EMP',
        name: 'EMP',
        component: () => import('../views/EMP/EMP.vue')
      },
      {
        path: 'FOOD',
        name: 'FOOD',
        component: () => import('../views/FOOD/FOOD.vue')
      },
      {
        path: 'DRINK',
        name: 'DRINK',
        component: () => import('../views/FOOD/DRINK.vue')
      },
      {
        path: 'LIQUOR',
        name: 'LIQUOR',
        component: () => import('../views/FOOD/LIQUOR.vue')
      },
      {
        path: 'MEDICINE',
        name: 'MEDICINE',
        component: () => import('../views/FOOD/MEDICINE.vue')
      },
      {
        path: 'SPICY',
        name: 'SPICY',
        component: () => import('../views/FOOD/SPICY.vue')
      },
      {
        path: 'SUPERMARKET',
        name: 'SUPERMARKET',
        component: () => import('../views/FOOD/SUPERMARKET.vue')
      },
      {
        path: 'TEA',
        name: 'TEA',
        component: () => import('../views/FOOD/TEA.vue')
      },
      {
        path: 'VEGETTABLE',
        name: 'VEGETTABLE',
        component: () => import('../views/FOOD/VEGETTABLE.vue')
      },
    ]
  }
]

const router = new VueRouter({
  mode: 'history',
  base: process.env.BASE_URL,
  routes
})

export default router
