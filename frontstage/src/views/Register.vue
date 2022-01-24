<template>
    <div class="MAIN">
        <div class="HEADER">
            <SEARCHBAR/>
        </div>
        <div class="CONTENT">
            <v-card
            class="mx-auto"
            max-width="550"
            outlined
            >
            
            <a-card title="新用户注册">
            </a-card>
            <v-container>
                <a-form :label-col="labelCol" :wrapper-col="wrapperCol">
                    <v-row>
                        <v-col cols="12" >
                            <a-form-item label="员工编号 : " has-feedback validate-status="success">
                            <a-input id="userno" placeholder="请输入8码员工编号" v-model="this.userinfo.userNo"/>
                            </a-form-item>
                            <a-form-item label="密码 : " has-feedback validate-status="success">
                            <a-input
                                v-decorator="[
                                'password',
                                { rules: [{ required: true, message: '请输入密码' }] },
                                ]"
                                type="password"
                                placeholder="请输入密码"
                                v-model="this.userinfo.password"
                            >
                                <a-icon slot="prefix" type="lock" style="color: rgba(0,0,0,.25)" />
                            </a-input>
                            </a-form-item>
                            <a-form-item label="信箱 : " has-feedback validate-status="success">
                            <a-input id="email" placeholder="建议使用公司信箱" v-model="this.userinfo.email"/>
                            </a-form-item>  
                            <a-form-item :wrapper-col="{ span: 20, offset: 9 }">
                            <a-button type="primary" shape="round" size="large" :loading="load" @click="Register()">
                                Register
                            </a-button>
                            </a-form-item>                          
                        </v-col>
                    </v-row>
                </a-form>
            </v-container>
            </v-card>
        </div>
    </div>
</template>

<script>
import axios from 'axios'
import SEARCHBAR from '../components/Utility/SEARCHBAR'
export default {
    name: 'COMMENT',
    components: {
        SEARCHBAR
    },
    data: () => ({
        load: false,
        labelCol: {
        xs: { span: 24 },
        sm: { span: 4 },
        },
        wrapperCol: {
        xs: { span: 24 },
        sm: { span: 15 },
      },
      userinfo: {
            userNo: '',
            password: '',
            email: ''
        }
    }),
    methods: {
        Register()
        {
            this.load = true;
            // axios.post('', this.userinfo)
            // .then(res => {
                //this.load = false;
                // this.$router.push('/Login');
                // this.$message.success('Register Success ~ ');
            // })
            // .then(err => {
                    //this.$message.error('Register Failed ~ Please Try Again')
            // })
        }
    }
}
</script>

<style lang="scss" scoped>
    .CONTENT{
        margin-top: 100px;
    }
</style>