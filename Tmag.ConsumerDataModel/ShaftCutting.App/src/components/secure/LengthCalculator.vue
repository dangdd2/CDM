<template>
  <div class="length-calculator" :class="{invertFont: butt.templateText != null}">

    <div class="row justify-items-center">
      <div class="col">
        <input type="text" class="form-control form-control-lg text-center"
               placeholder="Scan Barcode" ref="barcode"
               v-model="barcodeDisplay" disabled="disabled" />
      </div>
    </div>
    <div class="row display justify-content-center" v-show="butt.templateText != null">
    
      <div class="col sectionsWrapper"  :class="{
       fail: (tip.templateText != null && tip.templateText !== tip.templateCheckText && (tip.templateText !== 'NO' || (tip.templateText === 'NO' && tip.templateCheckText != null))),
       pass: (tip.templateText != null && (tip.templateText === tip.templateCheckText) || (tip.templateText == 'NO' && tip.templateCheckText == null)),
       waiting: (tip.templateText != null && (tip.templateCheckText == null && tip.templateText !== 'NO'))}">
        <h3 class="invert">Tip</h3>
        <div class="row">
          <div class="col border d-flex align-items-center justify-content-center" v-bind:style="{'background-color': tip.templateColor}">
            <h1>Template: {{tip.templateText}}</h1>
          </div>
          <div class="col border d-flex align-items-center justify-content-center" v-bind:style="{'background-color': tip.templateCheckColor}"
               v-if="tip.templateText != 'NO'">
            <h1 v-show="tip.templateCheckText != null && tip.templateCheckText.length > 0">Template: {{tip.templateCheckText}}</h1>
            <h1 class="waitingForScanText" v-show="tip.templateCheckText == null && tip.templateCheckText == null  && tip.templateText !== 'NO'">Scan Template</h1>
          </div>
        </div>
        <div class="row">
          <div class="col border d-flex align-items-center justify-content-center" v-bind:style="{'background-color': tip.templateColor}">
            <h1>Length: {{tip.length}}</h1>
          </div>
          <!--<div class="col border d-flex align-items-center justify-content-center">

          </div>-->
        </div>
      </div>
        <div class="col sectionsWrapper"  :class="{
       fail: (butt.templateText != null && butt.templateText !== butt.templateCheckText),
       pass: (butt.templateText != null && butt.templateText === butt.templateCheckText),
       waiting: (butt.templateText != null && (butt.templateCheckText == null))}">
        <h3 class="invert">Butt</h3>
        <div class="row ">
          <div class="col border d-flex align-items-center justify-content-center" v-bind:style="{'background-color': butt.templateColor}">
            <h1>Template: {{butt.templateText}}</h1>
          </div>
          <div class="col border d-flex align-items-center justify-content-center" v-bind:style="{'background-color': butt.templateCheckColor}">
            <h1 v-show="butt.templateCheckText != null && butt.templateCheckText.length > 0">Template: {{butt.templateCheckText}}</h1>
            <h1 class="waitingForScanText" v-show="butt.templateCheckText == null && butt.templateCheckText == null">Scan template</h1>
          </div>
        </div>
        <div class="row">
          <div class="col border d-flex align-items-center justify-content-center" v-bind:style="{'background-color': butt.templateColor}">
            <h1>Length: {{butt.length}}</h1>
          </div>
          <!--<div class="col border d-flex align-items-center justify-content-center">

          </div>-->
        </div>
      </div>
    </div>
    <div class="row footer">
      <div class="col justify-content-center invert">
        <h2 v-show="totalLength != null">Total Length: {{totalLength}}</h2>
      </div>
    </div>
  </div>
</template>
<script>
  export default {
    name: "lengthCalculator",
    data() {
      return {
        barcode: "",
        butt: { templateCheckText: null, templateCheckColor: null, templateText: null, templateColor: null, length: null },
        tip: { templateCheckText: null, templateCheckColor: null, templateText: null, templateColor: null, length: null },
        totalLength: null,
        shiftDown: false,
        barcodeDisplay: "",
        clubCutService: this.$root.store.ClubCut
      };
    },
    methods: {
      clear: function () {
        this.butt.templateCheckColor = null;
        this.butt.templateCheckText = null;
        this.tip.templateCheckColor = null;
        this.tip.templateCheckText = null;
        this.totalLength = null;
        this.barcodeDisplay = "";

      },
      scannedWorkOrder: function () {
        if (this.barcode.length < 18) {
          return;
        };

        this.clear();
        this.barcodeDisplay = this.barcode;
        var self = this;
        var buttTemplate = self.barcode.substr(2, 2);
        var buttLength = self.barcode.substr(4, 2) + "." + self.barcode.substr(6, 2);

        var tipTemplate = self.barcode.substr(8, 2);
        var tipLength = self.barcode.substr(10, 2) + "." + self.barcode.substr(12, 2);

        var finalLength = self.barcode.substr(14, 2) + "." + self.barcode.substr(16, 2);

        self.butt.templateColor = self.clubCutService.getColor("0",buttTemplate);
        self.butt.templateText = buttTemplate;
        self.butt.length = buttLength;

        self.tip.templateColor = self.clubCutService.getColor("1",tipTemplate);
        self.tip.templateText = tipTemplate;
        self.tip.length = tipLength;
        self.totalLength = finalLength;
      },
      scannedButtTemplate: function () {
        this.butt.templateCheckText = this.barcode.substr(2, 2);
        this.butt.templateCheckColor = this.clubCutService.getColor("0",this.butt.templateCheckText);
      },
      scannedTipTemplate: function () {
        this.tip.templateCheckText = this.barcode.substr(2, 2);
        this.tip.templateCheckColor = this.clubCutService.getColor("1",this.tip.templateCheckText);
      },
      barcodeScanned: function () {
        if (this.barcode.substr(0, 2) === "SC")
          this.scannedWorkOrder();
        else if (this.barcode.substr(0, 2) === "BT")
          this.scannedButtTemplate();
        else if (this.barcode.substr(0, 2) === "TP")
          this.scannedTipTemplate();


        this.barcode = "";
        this.shiftDown = false;
      },
      buttTemplate: function () {

      },
      fetchData: function () {
        var vm = this;
        this.clubCutService.loadTemplates();
        //setTimeout(function () {
        //  vm.$refs.barcode.focus();
        //}, 500);
      },
      barcodeWatcher: function (event) {
        event.stopPropagation();
        event.preventDefault();
        var keyCode = event.which || event.keyCode;
        if (keyCode == 13) {
          this.barcodeScanned();
          return;
        } else if (keyCode == 16) {
          this.shiftDown = true;
          return;
        }
        this.barcode += (this.shiftDown ? event.key.toUpperCase() : event.key);
        this.shiftDown = false;
      }
    },
    created() {
      this.fetchData();
      window.addEventListener("keyup", this.barcodeWatcher);
    },
    beforeDestroy: function () {
      window.removeEventListener("keyup", this.barcodeWatcher);
    },
    watch: {

    }
  };
</script>
<!-- Add "scoped" attribute to limit CSS to this component only -->
<style lang="scss" scoped>
  @import "../../assets/scss/_variables";
  $pass: $green;
  $fail: $red;
  $waiting: $blue;
  .length-calculator {
    height: 100%;
    width: 100%;
    overflow: hidden;
    position: relative;

    h1{
      font-size:3.5rem !important;
      filter: invert(1) grayscale(1) contrast(100);
    background: inherit;
    color: transparent;
    -webkit-background-clip: text;
    background-clip: text;
       }

    .form-control:focus {
        border: none;
        box-shadow: none;
      }
 .form-control:disabled {
        background:none !important;
      }
    }

  .footer{
    height:50px;
    width:100%;
    position:fixed;
    top:auto;
    bottom:0px;
  }

  .invertFont {
    .invert { color:#fff; }
  }

  .row{
    margin-left:0px !important;
    margin-right:0px !important;}

  .fail {
   // background-color:$fail;
    -webkit-animation: flash linear .5s infinite;
	  animation: flash linear .5s infinite;
    .col{
          border-color:darken($fail,20%) !important;
        }
  }

   .pass {
    background-color:$pass;
     -webkit-animation: none;
	  animation: none;
  }
  .waiting {
     background-color:$waiting !important;
      -webkit-animation: none;
	  animation: none;
  }
  .waitingForScanText{
    font-style:italic;
    opacity:.5;
  }
  .display {
    position: relative;
    height: calc(100% - 50px);
    position: relative;
    .sectionsWrapper {
                      // padding:15px;
    .row

  {
    height: 40%;
    width:100%;

    .col {
           height:100%;
    h1 {
      }

    }
                    }
  }
  }


  @-webkit-keyframes flash {
	0% { background-color: $fail; } 
	//50% { background-color: .1; } 
	100% { background-color: lighten($fail,60%); }
}
@keyframes flash {
	0% { background-color: $fail; } 
	//50% { background-color: .1; } 
	100% { background-color: lighten($fail,60%); }
}
</style>
