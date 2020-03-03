import Vue from 'vue'
import Router from 'vue-router'
import Login from '@/components/Login'
import Secure from '@/components/secure/Secure'
import LengthCalculator from '@/components/secure/LengthCalculator'
import Admin from '@/components/secure/Admin'

Vue.use(Router)

export default new Router({
  routes: [
    {
      path: '/',
      name: 'Login',
      component: Login
    },
    {
      path: '/secure',
      name: 'Secure',
      component: Secure,
      children: [{
        path: 'lengthCalculator',
        name: 'LengthCalculator',
        component: LengthCalculator
      },
      {
        path: 'admin',
        name: 'Admin',
        component: Admin
      }]
    }
  ]
})
