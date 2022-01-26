import Vue from 'vue'
import App from './App.vue'
import './registerServiceWorker'
import router from './router'
import store from './store'
import vuetify from './plugins/vuetify'
import { Button, message, Menu, Icon, Card, Form, Input ,Spin, Space } from 'ant-design-vue';
import { Comment, Avatar, List } from 'ant-design-vue'

Vue.component(Button.name, Button);
//vuetify
Vue.use(Icon).use(Menu).use(Card).use(Form).use(Input).use(Spin).use(Space);
//ant design
Vue.use(Comment).use(Avatar).use(List)
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
