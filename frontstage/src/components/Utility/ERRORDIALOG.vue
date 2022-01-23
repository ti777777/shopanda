<template>
  <v-row justify="center">
    <v-dialog
        v-model="SHOW"
        persistent
        max-width="320"
    >
    <v-card color="black" class="justify-center">
    <v-card-title class="text-h6" style="color:white">
    Token 发生错误请重新登入 !
    </v-card-title>
    <v-card-text style="color:white">
      Token error, please log in again.</v-card-text>
    <v-card-actions>
    <v-spacer></v-spacer>
    <v-btn
        color="red darken-1"
        text
        @click="GoLogin()"
    >
    确定
    </v-btn>
    </v-card-actions>
    </v-card>
    </v-dialog>
  </v-row>
</template>
<script>
export default {
    name: 'ERRORDIALOG',
    props: ['SHOW'],
    methods: {
      GoLogin()
      {
        localStorage.removeItem('access_token');
        this.$router.push('/Login');
        location.reload();
      }
    }
}
</script>

<style>

</style>