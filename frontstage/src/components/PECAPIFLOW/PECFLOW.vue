<template>
    <div class="d-flex flex-column justify-space-between align-center">
    <v-slider
      v-model="width"
      class="align-self-stretch"
      min="200"
      max="1024"
      step="1"
    ></v-slider>

    <v-img
      :aspect-ratio="16/9"
      :width="width"
      src= "/img/PEC_WebApi_Flow.jpg"
    ></v-img>
    </div>
</template>

<script>
    export default {
        name: 'PECFLOW',
        data: () => ({
            width: 300
        })
    }
</script>

<style lang="scss" scoped>

</style>