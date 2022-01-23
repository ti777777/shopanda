import Vue from 'vue'
import App from './App.vue'
import './registerServiceWorker'
import router from './router'
import store from './store'
import vuetify from './plugins/vuetify'
import { Button, message, Menu, Icon} from 'ant-design-vue';

Vue.component(Button.name, Button);
Vue.use(Icon).use(Menu);
Vue.config.productionTip = false;

//Message
Vue.prototype.$message = message;
message.config({
  top:`100px`, // 到页面顶部距离
  maxCount: 1, // 最大显示数, 超过限制时，最早的消息会被自动关闭
  duration: 2
});

new Vue({
  router,
  store,
  vuetify,
  render: h => h(App)
}).$mount('#app')
