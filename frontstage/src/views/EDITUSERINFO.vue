<template>
    <div>
        <CAROUSEL/>
    </div>
</template>

<script>
    import CAROUSEL from '../components/Utility/CAROUSEL'
    export default {
        name: 'EDITUSERINFO',
        components: {
            CAROUSEL
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

</style>