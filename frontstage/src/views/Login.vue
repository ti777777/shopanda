<template>
<div class="MAIN">
    <div class="HEADER">
        <SEARCHBAR/>
    </div>
    <div class='loginDoc'>
        <div class="main">
        <v-card
            class="mx-auto"
            max-width="400"
            outlined
        >
        <v-img
        height="350"
        src="/img/bytedance.jpg"
        ></v-img>
        <v-form v-model="valid">
            <v-container>
            <v-row>
            <v-col cols="12">
                <v-text-field
                    v-model="userno"
                :rules="[UserNoRules.required]"
                :counter="8"
                label="員工編號"
                outlined
                dense
                ></v-text-field>
            </v-col>
            </v-row>
            <v-row>
            <v-col cols="12">
                <v-text-field
                    :append-icon="show ? 'mdi-eye' : 'mdi-eye-off'"
                    :rules="[PasswordRules.required]"
                    :type="show ? 'text' : 'password'"
                    name="input-10-2"
                    label="密碼"
                    v-model="password"
                    hint="不得爲空"                    
                    outlined
                    dense
                    v-on:click="show = !show"
                ></v-text-field>
            </v-col>
            </v-row>  
        <v-card-actions class="justify-center">
        <a-button type="primary" shape="round" size="large" :loading="load" @click="login()">
            Login
        </a-button>
        </v-card-actions>
        </v-container>
        </v-form>
        </v-card>
        </div>
    </div>
</div>
</template>

<script>
    import axios from 'axios'
    import SEARCHBAR from '../components/Utility/SEARCHBAR'
    export default {
        name: 'Login',
        components:
        {
            SEARCHBAR
        },
        data: () => ({
            load: false,
            show: false,
            valid: false,
            userno: '',
            password: '',
            UserNoRules: {
                required: value => !!value || '員工編號不得爲空',
            },
            PasswordRules: {
                required: value => !!value || '密碼不得爲空',
            },
        }),
        methods:
        {
            login()
            {
                if(this.userno == '' || this.password == '')
                {
                    this.$message.error('账号密码不得为空');
                }
                else
                {
                    this.load = true;
                    //Params            
                    let params = new FormData();
                    params.append('client_id', 'client')
                    params.append('client_secret', 'secret')
                    params.append('grant_type', 'password')
                    params.append('username', this.userno) 
                    params.append('password', this.password)
                    //Post GetToken
                    axios.post('http://localhost:5002/connect/token',
                    params,
                    {
                        headers:{
                            'Content-Type': 'multipart/form-data; boundary=<calculated when request is sent>' 
                        }
                    })
                    .then(res => {
                        this.$store.commit('setUserInfo', res);
                        this.$store.commit('setToken', res);
                        this.load = false;
                        this.$router.push('/Home');
                        this.$message.success('登入成功 ~ ');
                    })
                    .catch(err => {
                        this.$message.error('账号密码有误 !!!!');
                        this.load = false;
                    });
                }
            }
        }
    }
</script>

<style lang="scss" scoped>
    .loginDoc{
        margin-top: 90px;
    }
</style>