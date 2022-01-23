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
            
        })
    }
</script>

<style lang="scss" scoped>
    .loginDoc{
        margin-top: 90px;
    }
</style>