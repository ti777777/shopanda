<template>
    <div class="PECMAIN">
        <div class="HEADER">
            <SEARCHBAR/>
            <CAROUSEL/>
        </div>
        <div class="PEC_FLOW">
            <PECFLOW v-if="show"/>
        </div>
        <!--load error Jump-->
        <ERRORDIALOG :SHOW = "errDiaLog"/>
        <!---->
    </div>
</template>

<script>
    import CAROUSEL from '../components/Utility/CAROUSEL'
    import PECFLOW from '../components/PECAPIFLOW/PECFLOW'
    import SEARCHBAR from '../components/Utility/SEARCHBAR'
    import ERRORDIALOG from '../components/Utility/ERRORDIALOG'
    export default {
        name: 'PEC',
        components: {
            CAROUSEL,
            PECFLOW,
            SEARCHBAR,
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
    .PEC_FLOW{margin: 70px 0;}
</style>