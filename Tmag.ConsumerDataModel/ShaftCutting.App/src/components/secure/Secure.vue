<template>
    <transition name="fadein">
      <div id="app">
    <div class="header">
      <div class="menu">
        <router-link tag="i" class="fal fa-cog" to="admin" v-show="$root.$route.name !== 'Admin'"></router-link>
        <router-link tag="i" class="fal fa-times" to="lengthCalculator" v-show="$root.$route.name === 'Admin'"></router-link>
      </div>
    <img src="@/assets/logo.jpg">

      </div>
    <div class="body">
   <router-view></router-view>
      </div>
  </div>
      
    </transition>
</template>
<script>
  export default {
    name: "secure",
    data() {
      return {
       
      };
    },
    methods: {
      goToAdmin: function () {
        this.$router.push("admin");
      },
      fetchData: function () {

      }
    },
    created() {
      this.fetchData();
    },
   
    watch: {

    }
  };
</script>
<!-- Add "scoped" attribute to limit CSS to this component only -->
<style lang="scss" scoped>
 
</style>
