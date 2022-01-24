<template>
    <div class="EMPMAIN">
        <div class="HEADER">
            <SEARCHBAR/>
            <CAROUSEL/>
        </div>
        <div class="EMPREPORT">
            <EMPREPORT/>
        </div>
    </div>
</template>

<script>
    import CAROUSEL from '../components/Utility/CAROUSEL'
    import EMPREPORT from '../components/EMP/EMPREPORT'
    import SEARCHBAR from '../components/Utility/SEARCHBAR'
    export default {
        name: 'EMP',
        components: {
            CAROUSEL,
            EMPREPORT,
            SEARCHBAR
        },
        data: () => ({
            
        })
    }
</script>

<style lang="scss" scoped>
    .EMPREPORT{margin: 70px 0;}
</style>