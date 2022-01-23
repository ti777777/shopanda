<template>
    <div>
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
        <v-btn color="primary" @click="login()">
            Login
        </v-btn>
        </v-card-actions>
        </v-container>
        </v-form>
        </v-card>
    </div>
</template>

<script>
    import axios from 'axios'
    export default {
        name: 'LOGINFORM',
        data: () => ({
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
        components: {
        },
        methods:
        {
            login(){
                if(this.userno == '' || this.password == '')
                {
                    this.$message.error('账号密码不得为空')
                }
                else
                {
                    localStorage.setItem('access_token', "jdoasjdoasijd");
                    location.reload();
                    this.$router.push('/Home');
                    this.$message.success('登入成功 ~ ');
                    // //Params            
                    // let params = new FormData();
                    // params.append('client_id', 'client')
                    // params.append('client_secret', 'secret')
                    // params.append('grant_type', 'password')
                    // params.append('username', this.userno) 
                    // params.append('password', this.password)
                    // //Post GetToken
                    // axios.post('http://localhost:5002/connect/token',
                    //             params,
                    //             {
                    //                 headers:{
                    //                     'Content-Type': 'multipart/form-data; boundary=<calculated when request is sent>' 
                    //                 }
                    //             })
                    // .then(response => {
                    //     localStorage.setItem('access_token', response.data.access_token);
                    //     localStorage.setItem('refresh_token', response.data.refresh_token);
                    //     this.$router.push('/Home');
                    //     location.reload();
                    //     this.$message.error('登入成功 ~ ')
                    // })
                    // .catch(err => {
                    //     localStorage.removeItem('access_token');
                    //     this.$message.error('账号密码有误 !!!!')
                    // });
                }
            }
        }
    }
</script>

<style lang="scss" scoped>

</style>