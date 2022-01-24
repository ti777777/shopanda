<template>
    <div class="MAIN">
        <div class="HEADER">
            <SEARCHBAR/>
            <CAROUSEL/>
        </div>
        <div class="CONTENT">
            
        </div>
    </div>
</template>

<script>
import SEARCHBAR from '../components/Utility/SEARCHBAR'
import CAROUSEL from '../components/Utility/CAROUSEL'
export default {
    name: 'COMMENT',
    components: {
        SEARCHBAR,
        CAROUSEL
    }
}
</script>

<style lang="scss" scoped>

</style>