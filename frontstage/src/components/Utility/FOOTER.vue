<template>
    <v-footer
    color="primary lighten-1"
    padless
    >
    <v-row
      justify="center"
      no-gutters
    >
    <v-btn
        v-for="link in links"
        :key="link.label"
        color="white"
        text
        rounded
        class="my-2"
        @click="openPage(link.url)"
    >
    {{ link.label }}
    </v-btn>
    <v-col
    class="primary lighten-2 py-4 text-center white--text"
    cols="12"
    >
    2012 - {{ new Date().getFullYear() }}
    </v-col>
    </v-row>
  </v-footer>
</template>

<script>
    export default {
        name: 'FOOTER',
        data: () => ({
        links: [
            {label: '首页', url: '/Home'},
            {label: '关于统一企业', url: 'http://www.uni-president.com.cn/'},
            {label: '统一生鲜', url: '#'},
            {label: '人工服务', url: ''},
        ],
        }),
        methods: {
            openPage(url)
            {
                window.open(url);
            }
        }
    }
</script>

<style lang="scss" scoped>

</style>