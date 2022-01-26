<template>
    <div class="HOMEMAIN">
        <div class="HEADER">
            <SEARCHBAR/>
            <CAROUSEL/>
        </div>
    </div>
</template>

<script>
    import SEARCHBAR from '../../components/Utility/SEARCHBAR'
    import CAROUSEL from '../../components/Utility/CAROUSEL'
    export default {
        name: 'Home',
        components: {
            SEARCHBAR,
            CAROUSEL
        }
    }
</script>

<style lang="scss" scoped>
</style>