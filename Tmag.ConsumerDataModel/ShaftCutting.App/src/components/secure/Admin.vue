<template>
  <div class="">
    <table class="table">
      <thead>
        <tr>
          <th>Type</th>
          <th>Template Code</th>
          <th>Color</th>
        </tr>
        <tr v-for="(item, index) in clubCutService.list">
          <td>
            <select class="form-control" v-model="item.type">
              <option :value="0">Butt</option>
              <option :value="1">Tip</option>
            </select>
          </td>
          <td><input type="text" class="form-control" v-model="item.text" /></td>
          <td v-bind:style="{'background-color': item.colors.hex}">
            <div class="pointer" v-on:click="item.showPicker = !item.showPicker"> {{item.colors.hex}} </div>
            <div class="color-picker" v-show="item.showPicker">
              <color-picker v-model="item.colors" />
            </div>
          </td>
        </tr>
        <tr>
          <td colspan="3">
            <button class="btn btn-outline-primary w-100" v-on:click="addNew">New Template</button>
          </td>
        </tr>
      </thead>
    </table>
    <button class="btn btn-outline-success" v-on:click="save">Save</button>
  </div>
</template>
<script>
  import { Chrome } from 'vue-color'
  export default {
    components: {
      'colorPicker': Chrome
    },
    name: "Admin",
    data() {
      return {
        clubCutService: this.$root.store.ClubCut
      }
    },
    methods: {
      addNew: function () {
        this.clubCutService.list.push(this.clubCutService.newTemplate());
      },
      save: function () {
        this.clubCutService.save(this.clubCutService.list).then(function () {
          this.$toasted.show("Templates saved", {
          theme: "primary",
          position: "bottom-right",
          duration: 2000
        });
        }, function () {
          this.$toasted.show("Templates failed to save", {
          theme: "primary",
          position: "bottom-right",
          duration: 2000,
          type:'error'
        });
          });
        
      },
      fetchData: function () {
        var vm = this;
        this.clubCutService.loadTemplates();

      }
    },
    created() {
      this.fetchData();
    },
    beforeDestroy: function () {
    },
    watch: {
      'clubCutService.list': {
        handler: function () {
          for (var x = 0; x < this.clubCutService.list.length; x++) {
            var item = this.clubCutService.list[x];
            item.color = item.colors.hex;
          }

        },
        deep: true
      }
    }
  };
</script>
<!-- Add "scoped" attribute to limit CSS to this component only -->
<style lang="scss" scoped>
  .color-picker {
    position: absolute;
    right: 0;
    margin: auto;
    display: inline-block;
    z-index:100;
  }

  .pointer {
    cursor: pointer;
    filter: invert(1) grayscale(1) contrast(100);
    background: inherit;
    color: transparent;
    -webkit-background-clip: text;
    background-clip: text;
  }
</style>
