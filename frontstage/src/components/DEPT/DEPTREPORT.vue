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
              {
                text: "",
                sortable: false,
                align: "center",
                value: 'edit'
              },
              { text: 'DEPTNO', value: 'deptno' },
              { text: 'DNAME', value: 'dname' },
              { text: 'LOC', value: 'loc' }
            ],
        }),
        mounted() {
          let userToken = this.$store.getters.token;
          if(userToken != null)
          {
            axios.get(
              'http://localhost:23568/api/V1/Home/GetDeptList',
              {
                headers: {
                  "Content-Type" : "application/json",
                  "Authorization" : "Bearer " + userToken
                }
              })
              .then(res => {
                if(res.data.status == 1)
                {
                  this.DEPTDATA = res.data.result;
                  this.loading = false;
                }
              })
              .catch(err => {
                this.errDiaLog = !this.errDiaLog;
            });
          }
          else
          {
            this.errDiaLog = !this.errDiaLog;
          }
        },
        methods: {
          EditEMP(item)
          {
            this.$message.error('該服務待完善');
          },
          DeleteEMP(item)
          {
            this.$message.error('該服務待完善');
          },
        }
    }
</script>

<style lang="scss" scoped>

</style>