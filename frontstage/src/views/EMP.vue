<template>
    <div class="EMPMAIN">
        <div class="SEARCHBAR">
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
    export default {
        name: 'EMP',
        components: {
            CAROUSEL,
            EMPREPORT
        },
        data: () => ({
            
        }),
        methods: 
        {

        },
        created()
        {
          if(localStorage.getItem('access_token') == null)
          {
            localStorage.removeItem('access_token');
            this.$router.push('/Login');
            this.$message.error('请先登入系统 ~ ');
          }
        },
    }
</script>

<style lang="scss" scoped>
    .EMPREPORT{margin: 70px 0;}
</style>