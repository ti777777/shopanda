<template>
    <div class='loginDoc'>
        <LOGINFORM/>
    </div>
</template>

<script>
    import LOGINFORM from '../components/Login/LoginForm'
    export default {
        name: 'Login',
        components:
        {
            LOGINFORM
        },
        data: () => ({
            
        }),
        beforeCreate(){
            if(localStorage.getItem('access_token') != null)
            {
                this.$router.push('/Home');
            }
        },
        methods: 
        {

        }
    }
</script>

<style lang="scss" scoped>
    .loginDoc{
        margin-top: 90px;
    }
</style>