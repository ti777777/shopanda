<template>
<div>
  <!--data table-->
  <v-container>
    <v-row>
      <v-col cols="12" lg="12" md="12" sm="12">
      <v-data-table
      dense
      :headers="headers"
      :items="EMPDATA"
      item-key="name"
      class="elevation-1"
      :loading="loading"
      loading-text="Loading... Please wait"
      >

    <template v-slot:[`item.edit`]="{ item }">
      <v-icon
        small
        class="mr-2"
        @click="EditEMP(item)"
      >
        mdi-pencil
      </v-icon>
      <v-icon
        small
        @click="DeleteEMP(item)"
      >
        mdi-delete
      </v-icon>
    </template>
    </v-data-table>
      </v-col>
    </v-row>
  </v-container>
  <!---->

  <!--tip dialog-->
  <v-snackbar
  v-model="snackbar"
  timeout="2000"
  centered
  height="65"
  >
  删除服务尚未开通&nbsp;敬请期待 ~ 
  <template v-slot:action="{ attrs }">
    <v-btn
      color="pink"
      text
      v-bind="attrs"
      @click="snackbar = !snackbar"
    >
      Close
    </v-btn>
  </template>
  </v-snackbar>
  <!---->

  <!--load error Jump-->
  <ERRORDIALOG :SHOW = "errDiaLog"/>
  <!---->

  <!--dialog-->
  <v-dialog v-model="EditDialog" width="500">
    <v-card>
      <v-card-title class="text-h5 orange lighten-2">
        Edit
      </v-card-title>
      <v-form v-model="valid">
        <v-container>
          <v-row>
            <v-col cols="12">
                <v-text-field
                v-model="editdata.empno"
                :counter="8"
                :rules="[PublicRules.required]"
                label="員工編號"
                outlined
                dense
                disabled
                ></v-text-field>
            </v-col>
          </v-row>
          <v-row>
            <v-col cols="12">
                <v-text-field
                v-model="editdata.ename"
                :rules="[PublicRules.required]"
                label="员工姓名"
                outlined
                dense
                ></v-text-field>
            </v-col>
          </v-row>
          <v-row>
            <v-col cols="12">
                <v-text-field
                v-model="editdata.job"
                :rules="[PublicRules.required]"
                label="职称"
                outlined
                dense
                ></v-text-field>
            </v-col>
          </v-row>
          <v-row>
            <v-col cols="12">
                <v-text-field
                v-model="editdata.sal"
                :rules="[PublicRules.required]"
                label="薪水"
                outlined
                dense
                ></v-text-field>
            </v-col>
          </v-row>
          <v-row>
            <v-col cols="12">
                <v-text-field
                v-model="editdata.comm"
                :rules="[PublicRules.required]"
                label="奖金"
                outlined
                dense
                ></v-text-field>
            </v-col>
          </v-row>
          <v-row>
            <v-col cols="12">
                <v-text-field
                v-model="editdata.deptno"
                :rules="[PublicRules.required]"
                label="部门"
                outlined
                dense
                ></v-text-field>
            </v-col>
          </v-row>
        </v-container>
      </v-form>
      <v-divider></v-divider>
      <v-card-actions>
        <v-spacer></v-spacer>
        <v-btn
          depressed
          color="primary"
          @click="EditDialog = !EditDialog"
        >
          取消
        </v-btn>
        <v-btn
          depressed
          color="error"
          @click="UPDATEEMP()"
        >
          送出
        </v-btn>
      </v-card-actions>
    </v-card>
  </v-dialog>
  <!---->

  </div>
</template>

<script>
//axios pacckages
import axios from "axios";
import ERRORDIALOG from '../Utility/ERRORDIALOG'

export default {
  name: "EMPREPORT",
  components: {
    ERRORDIALOG
  },
  data: () => ({
    snackbar: false,
    errDiaLog: false,
    valid: false,
    editdata: {
      empno:'',
      ename:'',
      job: '',
      sal: '',
      comm: '',
      deptno: ''
    },
    EditDialog: false,
    loading: true,
    EMPDATA: [],
    headers: [
      {
        text: "",
        sortable: false,
        align: "center",
        value: 'edit'
      },
      { text: "EMPNO", value: "empno" },
      { text: "ENAME", value: "ename" },
      { text: "JOB", value: "job" },
      { text: "MGR", value: "mgr" },
      { text: "HIRDATE", value: "hiredate" },
      { text: "SAL", value: "sal" },
      { text: "COMM", value: "comm" },
      { text: "DEPTNO", value: "deptno" },
    ],
    PublicRules: {
        required: value => !!value || '该栏位不得爲空',
    },
  }),
  mounted() {
      axios.get("http://localhost:23568/api/V1/Home/GetEmployeeList", {
      headers: {
        "Content-Type": "application/json",
        Authorization: "Bearer " + localStorage.getItem("access_token"),
      },
      })
      .then((res) => {
        if (res.data.status == 1) {
          this.EMPDATA = res.data.result;
          this.loading = false;
        }
      })
      .catch((err) => {
        console.error(err);
        this.errDiaLog = !this.errDiaLog;
      });
  },
  methods: {
    //双向绑定员工资料
    EditEMP(item)
    {
      this.EditDialog = !this.EditDialog;
      this.editdata = item;
    },
    //执行更新员工资料
    UPDATEEMP() {
      axios.post('http://localhost:23568/api/V1/Home/UpdateEmpData',
      this.editdata,
      {
        headers: 
        {
          "Content-Type": "application/json",
          Authorization: "Bearer " + localStorage.getItem("access_token"),
        }
      })
      .then(res => {
        if(res.data.status == 1)
        {
          alert('更新成功 ~~');
        }
      })
      .catch(err => {
        console.error(err);
        alert('更新失败 ~~ 请联络管理者')
      })
      this.EditDialog = !this.EditDialog;
    },
    //删除员工
    DeleteEMP(item){
      this.snackbar = !this.snackbar;
    },
    //系统发生错误重新登入
    GOLOGIN()
    {
      localStorage.removeItem('access_token');
      this.$router.push('/Login');
    }
  },
};
</script>

<style lang="scss" scoped>
</style>