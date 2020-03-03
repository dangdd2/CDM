// The Vue build version to load with the `import` command
// (runtime-only or standalone) has been set in webpack.base.conf with an alias.
import Vue from 'vue'
import App from './App'
import router from './router'
import store from './dataStore/store';
import Toasted from 'vue-toasted';
import VueLocalForage from 'vue-localforage'
    import vueResource from 'vue-resource'; //https://github.com/pagekit/vue-resource
Vue.use(VueLocalForage);
var registerServiceWorker = require("serviceworker-loader!./service-worker.js");

Vue.config.productionTip = false;

Vue.use(Toasted);
    Vue.use(vueResource);

/* eslint-disable no-new */
window.app = new Vue({
  data() {
    return { store: store }
  },
  router,
  components: { App },
  template: '<App/>',
  http: {
            root: "/api/"//https://shaftcuttingapp.azurewebsites.net
        }
});


window.app.$mount("#app");


registerServiceWorker({ scope: '/' }).then(function () { console.log("workerService registered") },
function () { console.log("workerService failed")});
