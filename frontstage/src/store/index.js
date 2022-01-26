import Vue from 'vue'
import Vuex from 'vuex'
import router from '../router'

Vue.use(Vuex)

export default new Vuex.Store({
  state: {
    userInfo: null,
    token: null,
  },
  getters: {
    userInfo: (state) => {
      if (state.userInfo == null) 
      {
        let sessionUser = sessionStorage.getItem('user')
        if (sessionUser != null) 
        {
            state.userInfo = JSON.parse(sessionUser)
            return sessionUser
        } 
        else 
        {
            let localeUser = localStorage.getItem('user')
            if (localeUser != null) {
                state.userInfo = JSON.parse(localeUser)
            }
            return localeUser
        }
      }
      return state.userInfo
    },
    token: (state) => {
      if (state.token == null) {
          let sessionToken = sessionStorage.getItem('token')
          if (sessionToken != null) {
              state.token = sessionToken
              return sessionToken
          } else {
              let localeToken = localStorage.getItem('token')
              state.token = localeToken
              return localeToken
          }
      }
      return state.token
    },
  },
  mutations: {
    setToken(state, userInfo, flag = true) {
      if (flag) {
          localStorage.setItem('token', userInfo.data.access_token);
          localStorage.setItem('refreshToken', userInfo.data.refresh_token);
      } else {
          sessionStorage.setItem('token', userInfo.data.access_token);
          sessionStorage.setItem('refreshToken', userInfo.data.refresh_token);
      }
    },
    setUserInfo(state, userInfo, flag = true) {
      state.userInfo = JSON.stringify(userInfo);
      state.token = userInfo.data.access_token;
      if (flag) {
          localStorage.setItem('user', JSON.stringify(userInfo))
      } else {
          sessionStorage.setItem('user', JSON.stringify(userInfo))
      }
    },
    logout(state)
    {
      state.userInfo = null;
      state.token = null;
      localStorage.removeItem('token');
      localStorage.removeItem('user');
      localStorage.removeItem('refreshToken');
      router.push('/Login')
    }
  },
  actions: {
  },
  modules: {
  }
})
