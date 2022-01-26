<template>
  <div class="MAIN">
      <div class="HEADER">
          <SEARCHBAR/>
          <CAROUSEL/>
      </div>
      <div class="CONTENT">
        <router-view/>
      </div>
  </div>
</template>

<script>
import SEARCHBAR from '../../components/Utility/SEARCHBAR'
import CAROUSEL from '../../components/Utility/CAROUSEL'
export default {
    name: 'CATEGORY',
    components: {
      SEARCHBAR,
      CAROUSEL
    }
}
</script>

<style>
  .CONTENT{margin: 70px 0;}
</style>