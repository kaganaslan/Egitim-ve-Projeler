var siirler = [
  {
    name: "Bütün Şiirleri",
    alinti:
      "Bir çift güzel söz söyle yeter, Bir çift güzel söz, Gülüşünle süslü, halimle uyumlu",
    sairadi: "Şükrü Erbaş",
  },
  {
    name: "Sevince Ben",
    alinti: "Sevmek bir çiçek sapı gibi, üzümlü ve kedersiz.",
    sairadi: "Can Yücel",
  },
  {
    name: "Kene",
    alinti: "Kenetlenmişsin kalbime ilmek ilmek, nereye böyle bileym söyle",
    sairadi: "Kağan Aslan",
  },
  {
    name: "23 Nisan",
    alinti: "23 Nisan Gelince, Neredesin Görümce, Mutluluk Kalbimde",
    sairadi: "Sedat Üngüder",
  },
  {
    name: "Şiirlerim ve Ben",
    alinti: "Beni benden öğren, herkese aynı değilim.",
    sairadi: "Esma Sivri",
  },
  {
    name: "İstanbulu Dinliyorum",
    alinti: "İstanbul'u dinliyorum, gözlerim kapalı",
    sairadi: "Orhan Veli Kanık",
  },
];
// console.log(siirler);
// console.log(siirler[3].yazaradi);

var buton = document.querySelector("button");
var sairadi = document.querySelector("#sairadi");
var siiradi = document.querySelector("#siiradi");
var alinti = document.querySelector("#alinti");

buton.addEventListener("click", siirGetir);

function siirGetir() {
  var rastgele = Math.floor(Math.random() * siirler.length);
  siiradi.textContent = siirler[rastgele].name;
  sairadi.textContent = siirler[rastgele].sairadi;
  alinti.textContent = siirler[rastgele].alinti;
  //   alinti.innerHTML = `Şiirin Adı: ${siirler[rastgele].name} şiirin şairi: ${siirler[rastgele].sairadi}`
}
