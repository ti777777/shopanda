<template>
    <div>
        <PECFLOW v-if="show"/>
        <!--load error Jump-->
        <ERRORDIALOG :SHOW = "errDiaLog"/>
        <!---->
    </div>
</template>

<script>
    import PECFLOW from '../../components/PECAPIFLOW/PECFLOW'
    import ERRORDIALOG from '../../components/Utility/ERRORDIALOG'
    export default {
        name: 'PEC',
        components: {
            PECFLOW,
            ERRORDIALOG
        },
        data: () => ({
            errDiaLog: false,
            show: false
        }),
        mounted(){
          let userToken = this.$store.getters.token;
          if(userToken == null)
          {
              this.errDiaLog = !this.errDiaLog;
          }
          else
          {
              this.show = true;
          }
        }
    }
</script>

<style lang="scss" scoped>
    .CONTENT{margin: 70px 0;}
</style>