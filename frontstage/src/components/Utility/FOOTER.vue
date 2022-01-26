<template>
    <div class="main">
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
    </div>
</template>

<script>
    export default {
        name: 'FOOTER',
        data: () => ({
        links: [
            {label: '首页', url: '/Home'},
            {label: '关于字节跳动', url: 'https://www.bytedance.com/zh/'},
            {label: '心动外卖', url: '#'},
            {label: '抖音', url: 'https://www.douyin.com/'},
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
    .main{
        margin-top: 50px;
    }
</style>