<template>
    <router-view/>
</template>

<script>
export default {
  name: 'App'
}
</script>

<style lang="scss">
  @import 'assets/scss/site.scss';
  #app{height:100%;}
  .header{
    height:80px;
    background:#fff;
    position:relative;
    .menu {
            padding:15px;
            float:right;
            display:inline-block;
          }
  }
  .body{
    height:calc(100% - 80px);
    width:100%;

  }
</style>
