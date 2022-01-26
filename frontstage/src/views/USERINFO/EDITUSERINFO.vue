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
            <a-card title="編輯使用者">
            </a-card>
            <v-container>
                <a-form :label-col="labelCol" :wrapper-col="wrapperCol">
                    <v-row>
                        <v-col cols="12" >
                            <a-form-item label="员工编号 : " has-feedback validate-status="success">
                            <a-input id="userno" v-model="userinfo.USERNO"/>
                            </a-form-item>
                            <a-form-item label="员工姓名 : " has-feedback validate-status="success">
                            <a-input id="userName" placeholder="请输入员工姓名" v-model="userinfo.USERNAME"/>
                            </a-form-item>
                            <a-form-item label="密码 : " has-feedback validate-status="error">
                            <a-input
                                v-decorator="[
                                'password',
                                { rules: [{ required: true, message: '修改密碼請聯絡管理員' }] },
                                ]"
                                type="password"
                                placeholder="修改密碼請聯絡管理員"
                                v-model="userinfo.USERPWD"
                                :disabled="true"
                            >
                                <a-icon slot="prefix" type="lock" style="color: rgba(0,0,0,.25)" />
                            </a-input>
                            </a-form-item>
                            <a-form-item label="信箱 : " has-feedback validate-status="success">
                            <a-input id="email" placeholder="建议使用公司信箱" v-model="userinfo.EMAILADDR"/>
                            </a-form-item>  
                            <a-form-item :wrapper-col="{ span: 20, offset: 9 }">
                            <a-button type="primary" shape="round" size="large" :loading="load" @click="Edit()">
                                Edit
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
    import SEARCHBAR from '../../components/Utility/SEARCHBAR'
    import jwt_decode from "jwt-decode";
    export default {
        name: 'EDITUSERINFO',
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
                USERNO: '',
                USERNAME: '',
                EMAILADDR: ''
            }
        }),
        methods: {
            EditUser(){
                axios.post('',this.userinfo)
                .then(res => {

                })
                .catch(err => {
                    
                })
            }
        },
        mounted() {
            if(this.$store.getters.userInfo != null)
            {
                let userInfoJson = JSON.parse(this.$store.getters.userInfo);
                let userInfo = jwt_decode(userInfoJson.data.access_token);
                this.userinfo.USERNO = userInfo.id;
                this.userinfo.USERNAME = userInfo.name;
                this.userinfo.EMAILADDR = userInfo.email;
            }
        }
    }
</script>

<style lang="scss" scoped>
    .CONTENT{margin-top: 100px;}
</style>