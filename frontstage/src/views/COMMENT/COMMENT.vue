<template>
    <v-container>
        <v-row>
            <v-col cols="12">
                <a-card title="騎手回饋" :bordered="false" :hoverable="true">
                    <a-list
                    v-if="comments.length"
                    :data-source="comments"
                    :header="`${comments.length} ${comments.length > 1 ? 'replies' : 'reply'}`"
                    item-layout="horizontal"
                    >
                    <a-list-item slot="renderItem" slot-scope="item">
                        <a-comment
                        :author="item.author"
                        :avatar="item.avatar"
                        :content="item.content"
                        :datetime="item.datetime"
                        />
                    </a-list-item>
                    </a-list>
                    <a-comment>
                    <a-avatar
                        slot="avatar"
                        src="https://zos.alipayobjects.com/rmsportal/ODTLcjxAfvqbxHnVXCYX.png"
                        alt="Han Solo"
                    />
                    <div slot="content">
                        <a-form-item>
                        <a-textarea :rows="4" :value="value" @change="handleChange" />
                        </a-form-item>
                        <a-form-item>
                        <a-button html-type="submit" :loading="submitting" type="danger" @click="handleSubmit">
                            Replay
                        </a-button>
                        </a-form-item>
                    </div>
                    </a-comment>
                </a-card>
            </v-col>
        </v-row>
    </v-container>
</template>

<script>
import moment from 'moment';
export default {
    name: 'COMMENT',
    data: () => ({
        comments: [],
        submitting: false,
        value: '',
        moment,
    }),
    methods: {
        handleSubmit() {
            if (!this.value) {
                return;
            }

            this.submitting = true;

            setTimeout(() => {
                this.submitting = false;
                this.comments = [
                {
                    author: 'Han Solo',
                    avatar: 'https://zos.alipayobjects.com/rmsportal/ODTLcjxAfvqbxHnVXCYX.png',
                    content: this.value,
                    datetime: moment().fromNow(),
                },
                ...this.comments,
                ];
                this.value = '';
            }, 1000);
        },
        handleChange(e) {
        this.value = e.target.value;
        },
    },
}
</script>

<style>
</style>