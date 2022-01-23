<template>
  <v-app>
    <SEARCHBAR/>
    <v-main>
      <router-view/>
    </v-main>
    <FOOTER/>
  </v-app>
</template>

<script>
import SEARCHBAR from './components/Utility/SEARCHBAR'
import FOOTER from './components/Utility/FOOTER'
export default {
  name: 'App',
  data: () => ({
    
  }),
  methods: {
    
  },
  components: {
    SEARCHBAR,
    FOOTER
  }
};
</script>

<style lang="scss" scoped>
</style>
