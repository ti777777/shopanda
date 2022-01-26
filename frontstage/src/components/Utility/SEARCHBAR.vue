<template>
    <div class="SEARCHBAR">
        <v-app-bar
          color="blue"
          dark
          prominent
          height=55
          fixed
        >
        <v-app-bar-nav-icon @click="drawer = !drawer">
        </v-app-bar-nav-icon>
        <v-toolbar-title>ByteDance</v-toolbar-title>
        <v-spacer></v-spacer>

        <v-btn icon v-on:click="goPage('EDITUSER')" v-if="user != null && user.name != null">
        <v-avatar
          color="red"
          size="35"
        >
        {{user.name}}
        </v-avatar>
        </v-btn>
        
        <!--Notice Btn-->
        <v-btn icon v-on:click="tips()">
        <v-icon>mdi-bell</v-icon>
        </v-btn>
        <!---->
        </v-app-bar>
        
        <!--tip dialog-->
        <v-snackbar
        v-model="snackbar"
        timeout="2000"
        centered
        height="65"
        >
        通知服务尚未开通&nbsp;敬请期待 ~ 
        <template v-slot:action="{ attrs }">
          <v-btn
            color="pink"
            text
            v-bind="attrs"
            @click="snackbar = !snackbar"
          >
            Close
          </v-btn>
        </template>
        </v-snackbar>
        <!---->

        <!--left sidebar-->
        <v-navigation-drawer
          class="white"
          v-model="drawer"
          :fixed="true"
          bottom
          temporary
          app
        >
        <v-list nav dense>
        
        <v-list-item-group
          active-class="red--text"
        >

        <!--Home-->
        <v-list-item
          to="/Home"
        >
        <v-list-item-icon>
          <v-icon>mdi-home</v-icon>
        </v-list-item-icon>
        <v-list-item-title>Home</v-list-item-title>
        </v-list-item>
        <!--level 1-->
        <v-list-group
          v-for="item in category"
          :key="item.id"
          :value="true"
          :prepend-icon="item.icon"
          no-action
        >
        <template v-slot:activator>
          <v-list-item-title>{{item.name}}</v-list-item-title>
        </template>
        <div
        v-for="subItem in item.children"
        :key="subItem.id">
        <!--level 2-->
        <v-list-group
          v-if="subItem.children.length > 0"
          :value="true"
          sub-group
        >
        <template v-slot:activator>
          <v-list-item-content>
            <v-list-item-title>{{subItem.name}}</v-list-item-title>
          </v-list-item-content>
        </template>
        <!--level 3-->
        <v-list-item
        v-for="subSubItem in subItem.children"
        :key="subSubItem.id"
        :to="'/category/' + subSubItem.slug">
          <v-list-item-icon>
            <v-icon></v-icon>
          </v-list-item-icon>
          <v-list-item-title>{{subSubItem.name}}</v-list-item-title>
        </v-list-item>
        </v-list-group>
        <v-list-item 
        :to="'/category/'+subItem.slug"  
        v-if="subItem.children.length == 0">
          <v-list-item-icon>
            <v-icon></v-icon>
          </v-list-item-icon>
          <v-list-item-title>{{subItem.name}}</v-list-item-title>
        </v-list-item>
        </div>
        </v-list-group>
        <!--Setting-->
        <v-list-item
        to="/Setting"
        v-if="user.roles == 'ADMIN'"
        >
        <v-list-item-icon>
          <v-icon>mdi-cog</v-icon>
        </v-list-item-icon>
        <v-list-item-title>Setting</v-list-item-title>
        </v-list-item>
        </v-list-item-group>
        </v-list>

        <!--login logout-->
        <template v-slot:append>
        <div class="pa-2">
          <v-btn block class="orange" v-on:click="goPage('Register')" v-if="!isLogin">
            Register
          </v-btn>
        </div>
        <div class="pa-2">
          <v-btn block class="orange" v-on:click="goPage('Login')" v-if="!isLogin">
            LogIn
          </v-btn>
        </div>
        <div class="pa-2">
          <v-btn block class="red" v-on:click="logout()" v-if="isLogin">
            Logout
          </v-btn>
        </div>
        </template>
        </v-navigation-drawer>
        <!---->
      </div>
</template>

<script>
    import axios from 'axios';
    import jwt_decode from "jwt-decode";
    export default {
        name: 'SEARCHBAR',
        data: () => ({
            user: {
              name: null,
              roles: null
            },
            isLogin: localStorage.getItem('token'),
            snackbar: false,
            drawer: false,
            category: []
        }),
        methods: {
            goPage(page){
              this.$router.push({name: page})
            },
            tips()
            {
              this.snackbar = !this.snackbar;
            },
            logout()
            {
              this.$store.commit('logout');
              this.$message.success('登出成功');
            }
        },
        mounted() {
          
          //載入USERINFO
          if(this.$store.getters.userInfo != null)
          {
            let userInfoJson = JSON.parse(this.$store.getters.userInfo);
            let userInfo = jwt_decode(userInfoJson.data.access_token);
            this.user.name = userInfo.name;
            this.user.roles = userInfo.role;
          }

          //載入SEARCHBAR
          axios.get('/static/Menu.json')
          .then(res => {
            this.category = res.data;
          })
          .catch(err => {
            this.$message.err('槽糕 ~ 载入Menu发生错误');
          })
        }
    }
</script>

<style lang="scss" scoped>
</style>