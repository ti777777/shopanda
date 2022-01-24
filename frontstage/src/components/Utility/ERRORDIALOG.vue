<template>
  <v-row justify="center">
    <v-dialog
        v-model="SHOW"
        persistent
        max-width="320"
    >
    <v-card color="black" class="justify-center">
    <v-card-title class="text-h6" style="color:white">
    登入過期 ! 请重新登入 !
    </v-card-title>
    <v-card-text style="color:white">
      Please log in to the system.</v-card-text>
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
        this.$router.push('/Login');
      }
    }
}
</script>

<style>

</style>