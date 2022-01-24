<template>
  <v-app>
    <v-main>
      <router-view/>
    </v-main>
    <FOOTER/>
  </v-app>
</template>

<script>
import FOOTER from './components/Utility/FOOTER'
export default {
  name: 'App',
  data: () => ({
  }),
  components: {
    FOOTER
  }
};
</script>

<style lang="scss" scoped>
</style>