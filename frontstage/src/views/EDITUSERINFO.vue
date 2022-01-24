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
    import CAROUSEL from '../components/Utility/CAROUSEL'
    import SEARCHBAR from '../components/Utility/SEARCHBAR'
    export default {
        name: 'EDITUSERINFO',
        components: {
            CAROUSEL,
            SEARCHBAR
        },
        data: () => ({
            
        })
    }
</script>

<style lang="scss" scoped>

</style>