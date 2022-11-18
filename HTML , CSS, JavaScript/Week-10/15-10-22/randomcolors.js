const colorpicker = document.querySelector("#colorpicker");
const body = document.querySelector("body");

var colors = [
  "#975C8D",
  "#F49D1A",
  "#DC3535",
  "#EF9A53",
  "#A0E4CB",
  "#FFFBC1",
  "#497174",
  "#7743DB",
  "#7D8F69",
  "#F6F6C9",
  "#CFB997",
  "#F0FF42",
  "#3C4048",
  "#D8D9CF",
  "#372948",
];

body.addEventListener("keypress", renkDegis);

function renkDegis(event) {
  var tus = "KeyA";
  if (event.code == tus) {
    let random = Math.floor(Math.random() * colors.length);
    body.style.backgroundColor = colors[random];
  }
}
