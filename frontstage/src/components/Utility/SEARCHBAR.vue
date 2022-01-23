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

        <!--Notice Btn-->
        <v-btn icon v-on:click="tips()">
        <v-icon>mdi-bell</v-icon>
        </v-btn>
        </v-app-bar>
        <!---->

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
          <v-btn block class="orange" v-on:click="goPage('login')" v-if="token">
            LogIn
          </v-btn>
        </div>
        <div class="pa-2">
          <v-btn block class="red" v-on:click="logout()" v-if="!token">
            Logout
          </v-btn>
        </div>
        </template>



        </v-navigation-drawer>
        <!---->
      </div>
</template>

<script>
    export default {
        name: 'SEARCHBAR',
        data: () => ({
            snackbar: false,
            token: (localStorage.getItem('access_token') == null),
            drawer: false,
            category: [
            {
              "id": 1,
              "name": "系统文件",
              "slug": "book",
              "icon":"mdi-book-alphabet",
              "children": [
                {
                  "id": 2,
                  "name": "PEC",
                  "slug": "PEC",
                  "children": [
                    {
                      "id": 3,
                      "name": "PEC WebApi Sop",
                      "slug": "PEC",
                      "children": []
                    }
                  ]
                },]
            },
            {
              "id": 4,
              "name": "档案维护",
              "slug": "档案维护",
              "icon":"mdi-grease-pencil",
              "children": [
                {
                  "id": 5,
                  "name": "員工清單",
                  "slug": "EMP",
                  "children": []
                },
                {
                  "id": 6,
                  "name": "部門清單",
                  "slug": "DEPT",
                  "children": []
                },
                {
                  "id": 7,
                  "name": "編輯使用者",
                  "slug": "EDITUSER",
                  "children": []
                },]
            },
            {
              "id": 8,
              "name": "产品分析",
              "slug": "产品分析",
              "icon":"mdi-video-input-antenna",
              "children": [
                {
                  "id": 9,
                  "name": "用户意见",
                  "slug": "COMMENT",
                  "children": []
                }]
            },
            ],

            items: [
                { title: '員工清單', icon: 'mdi-account' , page: 'EMP'},
                { title: '部門清單', icon: 'mdi-domain' , page: 'DEPT'},
                { title: '大众点评', icon: 'mdi-comment' , page: 'COMMENT'},
                { title: '編輯使用者', icon: 'mdi-account-group' , page: 'EDITUSER'},
                ],
        }),
        methods: {
            goPage(page){
            this.$router.push(page)
            },
            tips()
            {
              this.snackbar = !this.snackbar;
            },
            logout()
            {
              localStorage.removeItem('access_token');
              localStorage.removeItem('refresh_token');
              location.reload();
              this.$message.success('登出成功 ~ ');
            }
        },
        components: {
        }
    }
</script>

<style lang="scss" scoped>
</style>