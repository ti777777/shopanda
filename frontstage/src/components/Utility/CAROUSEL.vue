<template>
    <v-carousel :show-arrows="false" :cycle="true" height=350>
    <v-carousel-item
      v-for="(item,i) in items"
      :key="i"
      :src="item.src"
    ></v-carousel-item>
    </v-carousel>
</template>

<script>
    export default {
        name: 'CAROUSEL',
        data () {
        return {
            items: [
            {
                src: 'https://sf16-scmcdn-sg.ibytedtos.com/obj/static-sg/ies/bytedance_official/_next/static/images/0-390b5def140dc370854c98b8e82ad394.png',
            },
            {
                src: 'https://sf16-scmcdn-sg.ibytedtos.com/obj/static-sg/ies/bytedance_official/_next/static/images/3-9ea22bd593086f432ab75ee6c95c37de.png',
            },
            {
                src: 'https://sf16-scmcdn-sg.ibytedtos.com/obj/static-sg/ies/bytedance_official/_next/static/images/1-b4afd269ffb0ba19bd1dd33e3ed5cec3.png',
            },
            {
                src: 'https://sf16-scmcdn-sg.ibytedtos.com/obj/static-sg/ies/bytedance_official/_next/static/images/2-468bb0555d827d48bce4e178f085bf90.png',
            },
            {
                src: 'https://sf16-scmcdn-sg.ibytedtos.com/obj/static-sg/ies/bytedance_official/_next/static/images/3-9ea22bd593086f432ab75ee6c95c37de.png',
            },
            {
                src: 'https://sf16-scmcdn-sg.ibytedtos.com/obj/static-sg/ies/bytedance_official/_next/static/images/0-390b5def140dc370854c98b8e82ad394.png',
            },
            ],
        }
        },
    }
</script>

<style lang="scss" scoped>

</style>