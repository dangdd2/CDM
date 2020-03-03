
import Vue from 'vue'


function rgbToHsv(r, g, b) {
  r /= 255, g /= 255, b /= 255;

  var max = Math.max(r, g, b), min = Math.min(r, g, b);
  var h, s, v = max;

  var d = max - min;
  s = max == 0 ? 0 : d / max;

  if (max == min) {
    h = 0; // achromatic
  } else {
    switch (max) {
      case r: h = (g - b) / d + (g < b ? 6 : 0); break;
      case g: h = (b - r) / d + 2; break;
      case b: h = (r - g) / d + 4; break;
    }

    h /= 6;
  }

  return { h: h, s: s, v: v, a: 1 };
}
function hexToRgba(hex) {

  var result = /^#?([a-f\d]{2})([a-f\d]{2})([a-f\d]{2})$/i.exec(hex);
  var r = parseInt(result[1], 16);
  var g = parseInt(result[2], 16);
  var b = parseInt(result[3], 16);
  r /= 255, g /= 255, b /= 255;
  return { r: r, g: g, b: b, a: 1 };
}
function hexToHSL(hex) {
  var result = /^#?([a-f\d]{2})([a-f\d]{2})([a-f\d]{2})$/i.exec(hex);
  var r = parseInt(result[1], 16);
  var g = parseInt(result[2], 16);
  var b = parseInt(result[3], 16);
  r /= 255, g /= 255, b /= 255;
  var max = Math.max(r, g, b), min = Math.min(r, g, b);
  var h, s, l = (max + min) / 2;
  if (max == min) {
    h = s = 0; // achromatic
  } else {
    var d = max - min;
    s = l > 0.5 ? d / (2 - max - min) : d / (max + min);
    switch (max) {
      case r: h = (g - b) / d + (g < b ? 6 : 0); break;
      case g: h = (b - r) / d + 2; break;
      case b: h = (r - g) / d + 4; break;
    }
    h /= 6;
  }
  var HSL = new Object();
  HSL['h'] = h;
  HSL['s'] = s;
  HSL['l'] = l;
  HSL['a'] = 1;
  return HSL;
}

var colors = function (color) {
  var rgba = hexToRgba(color);
  return {

    hex: color,
    hsl: hexToHSL(color),
    hsv: rgbToHsv(rgba.r, rgba.g, rgba.b),
    rgba: rgba,
    a: 1
  };
};

var newTemplate = function () {
  return { type: 0, text: "", color: "#ffffff", colors: colors("#ffffff"), showPicker: false };
};

//var fakeList = [{ type: 0, text: "01", color: "#6610f2", colors: colors("#6610f2"),showPicker: false },
//                {type:0, text: "02", color: "#6f42c1", colors: colors("#6f42c1"),showPicker: false},
//                {type:0, text: "03", color: "#e83e8c", colors: colors("#e83e8c"),showPicker: false},
//                {type:0, text: "04", color: "#fd7e14", colors: colors("#fd7e14"),showPicker: false},
//                {type:1, text: "01", color: "#6610f2", colors: colors("#6610f2"),showPicker: false},
//                {type:1, text: "02", color: "#6f42c1", colors: colors("#6f42c1"),showPicker: false},
//                {type:1, text: "03", color: "#e83e8c", colors: colors("#e83e8c"),showPicker: false},
//                {type:1, text: "04", color: "#fd7e14", colors: colors("#fd7e14"),showPicker: false},
//                {type:1, text: "05", color: "#ffc107", colors: colors("#ffc107"),showPicker: false},
//                { type: 1, text: "06", color: "#20c997", colors: colors("#20c997"),showPicker: false }]

var list = [];
var getColor = function (type, template) {
  for (var x = 0; x < clubCut.list.length; x++) {
    var item = clubCut.list[x];
    if (item.type === type && item.text === template)
      return item.color;
  }
  return "RGBA(255,255,255,.5)";
};

function fixlist(l) {
  for (var x = 0; x < l.length; x++) {
    var i = l[x];
    i.colors = colors(i.color);
    i.showPicker = false;
  }
  return l;
}

var loadTemplates = function (id) {
  var self = window.app;
  return new Promise(function (resolve, reject) {
    self.$getItem("templates", function (data) {
      //
      if (data == null || data.length === 0) {
       // debugger;
        self.$http.get('values').then(function (response) {
          self.$setItem("templates",fixlist(response.data), function () {
            clubCut.list = fixlist(response.data);
            resolve();
          });

        }, function (data) {
          reject(data);
        });
      }
      else
        resolve(data);

      self.$http.get('values').then(function (response) {
          self.$setItem("templates",fixlist(response.data), function () {
            clubCut.list = fixlist(response.data);
            
          });

        }, function (data) {
        });
    })


  });
};

const clubCut = {
  list: list,
  loadTemplates: loadTemplates,
  getColor: getColor,
  newTemplate: newTemplate,
  save: function (values) {
    var self = window.app;
    return new Promise(function (resolve, reject) {
      self.$http.post('values/', values).then(function (response) {
        clubCut.list = fixlist(response.data);
         self.$setItem("templates", fixlist(response.data), function () {
          resolve();
          });
      }, function (data) {
        reject(data);
      });
    });
  }
};

export default clubCut;
