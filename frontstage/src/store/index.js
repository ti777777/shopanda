import Vue from 'vue'
import Vuex from 'vuex'
import router from '../router'

Vue.use(Vuex)

export default new Vuex.Store({
  state: {
    userInfo: null,
    token: null
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
    setToken(state, token, refreshToken, flag = true) {
      if (flag) {
          localStorage.setItem('token', token);
          localStorage.setItem('refresh_token', refreshToken);
      } else {
          sessionStorage.setItem('token', token);
          sessionStorage.setItem('token', refreshToken);
      }
    },
    setUserInfo(state, userInfo, flag = true) {
      state.userInfo = userInfo;
      state.token = userInfo.access_token;
      if (flag) {
          localStorage.setItem('user', JSON.stringify(userInfo))
      } else {
          sessionStorage.setItem('user', JSON.stringify(userInfo))
      }
      this.commit('setToken', userInfo.access_token, userInfo.refresh_token, flag)
    },
    logout(state)
    {
      console.error('执行登出了');
      state.userInfo = null;
      state.token = null;
      localStorage.removeItem('token')
      localStorage.removeItem('user')
      sessionStorage.removeItem('token')
      sessionStorage.removeItem('user')
      router.push('/Login')
    }
  },
  actions: {
  },
  modules: {
  }
})
