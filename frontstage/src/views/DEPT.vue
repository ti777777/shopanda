<template>
    <div class="DEPTMAIN">
        <div class="SEARCHBAR">
            <CAROUSEL/>
        </div>
        <div class="DEPTREPORT">
            <DEPTREPORT/>
        </div>
    </div>
</template>

<script>
    import CAROUSEL from '../components/Utility/CAROUSEL'
    import DEPTREPORT from '../components/DEPT/DEPTREPORT'
    export default {
        name: 'DEPT',
        components: {
            CAROUSEL,
            DEPTREPORT
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
    .DEPTREPORT{margin: 70px 0;}
</style>