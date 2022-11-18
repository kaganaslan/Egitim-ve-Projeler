let sayac = document.getElementById("sayac");
let arttir = document.getElementById("arttirbuton");
let azalt = document.getElementById("azaltbuton");

let count = 0;

arttir.addEventListener("click", arttirmaFonksiyonu);
azalt.addEventListener("click", azaltmaFonksiyonu);

function arttirmaFonksiyonu() {
  count = count + 1;
  sayac.innerText = count;
  if (count > 0) {
    sayac.style.color = "springgreen";
  } else if (count == 0) {
    sayac.style.color = "white";
  }
}

function azaltmaFonksiyonu() {
  count = count - 1;
  sayac.innerText = count;
  if (count < 0) {
    sayac.style.color = "crimson";
  } else if (count == 0) {
    sayac.style.color = "white";
  }
}
