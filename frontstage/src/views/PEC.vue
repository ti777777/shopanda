<template>
    <div class="PECMAIN">
        <div class="SEARCHBAR">
            <CAROUSEL/>
        </div>
        <div class="PEC_FLOW">
            <PECFLOW/>
        </div>
    </div>
</template>

<script>
    import CAROUSEL from '../components/Utility/CAROUSEL'
    import PECFLOW from '../components/PECAPIFLOW/PECFLOW'
    export default {
        name: 'PEC',
        components: {
            CAROUSEL,
            PECFLOW
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
    .PEC_FLOW{margin: 70px 0;}
</style>