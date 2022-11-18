//senkronize programlama

// selamlama();

// window.alert("senkronize programlama");

// const x = 5;
// const y = 12;

// console.log(x + y);

// function selamlama() {
//   console.log("Hoşgeldiniz");
// }

// console.log("Selamlar");

// const senkronize = () => {
//   console.log("Benim adım Barbaros");
// };

// senkronize();

//asenkronize çalışmaya giden yol daha doğrusu neden asenkron çalışmak zorundayız

// console.log("Şimdi uzun süreçli bir bekleme işlemi yapıyoruz");

// const asenkronize = () => {
//   setTimeout(() => {
//     console.log("Benim adım Barbaros");
//   }, 5000);
// };

// asenkronize();
// console.log("Nasılsın");

// işte bu gibi durumlarda cevap geç gelecek olan işlemler yapılırken undefined sonuçlar almamak adına kod bloklarımmızı asenkron çalıştırmamız gerekmektedir. bunun için async ve await keywordlerini kullanacağız. ya da fetchleme yaparken .then.then dyerek işlemleri sıraya sokacağız.

document.getElementById("yaziGetir").addEventListener("click", yaziGetir);

// function yaziGetir() {
//   fetch("./yazi.txt")
//     .then(function (yazidosyasi) {
//       return yazidosyasi.text();
//       console.log(yazidosyasi);
//     })
//     .then(function (data) {
//       console.log(data);
//     });
// }

// function yaziGetir() {
//   fetch("./yazi.txt")
//     .then((ahmet) => ahmet.text())
//     .then((mehmet) => console.log(mehmet))
//     .catch((err) => console.log(err));
// }

function yaziGetir() {
  fetch("./yazi.txt")
    .then((ahmet) => ahmet.text())
    .then((mehmet) => {
      document.getElementById("cikti").innerHTML = `<h1>${mehmet}</h1>`;
    })

    .catch((err) => console.log(err));
}
