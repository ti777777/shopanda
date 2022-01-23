<template>
<div>
<!--data table-->
  <v-container>
    <v-row>
      <v-col cols="12" lg="12" md="12" sm="12">
        <v-data-table
            dense
            :headers="headers"
            :items="DEPTDATA"
            item-key="name"
            class="elevation-1"
            :loading="loading"
            loading-text="Loading... Please wait"
            >
        </v-data-table>
      </v-col>
    </v-row>
  </v-container>
  <!---->
  <!--load error Jump-->
  <ERRORDIALOG :SHOW = "errDiaLog"/>
  <!---->
  </div>
</template>

<script>
    import axios from 'axios'
    import ERRORDIALOG from '../Utility/ERRORDIALOG'

    export default {
        name: 'DEPTREPORT',
        components: {
          ERRORDIALOG
        },
        data: () => ({
            errDiaLog: false,
            loading: true,
            DEPTDATA: [],
            headers: [
              { text: 'DEPTNO', value: 'deptno' },
              { text: 'DNAME', value: 'dname' },
              { text: 'LOC', value: 'loc' }
            ],
        }),
        mounted() {
          if( localStorage.getItem('access_token') != null)
          {
            axios.get(
              'http://localhost:23568/api/V1/Home/GetDeptList',
              {
                headers: {
                  "Content-Type" : "application/json",
                  "Authorization" : "Bearer " + localStorage.getItem('access_token')
                }
              })
              .then(res => {
                if(res.data.status ==1)
                {
                  this.DEPTDATA = res.data.result;
                  this.loading = false;
                }
              })
              .catch(err => {
                this.errDiaLog = !this.errDiaLog;
              });
          }
        }
    }
</script>

<style lang="scss" scoped>

</style>