// Dönüş değeri olmayan ve parametre almayan fonksiyonlar

// function selamlama() {
//   window.alert("Hoşgeldiniz");
// }

// selamlama();

//Dönüş değeri olmayan ve parametre alan

//parametre değerlerini istersek eşittir koyup tipini de kavramasını sağlayabiliriz. Eğer tip belirtmezsek aşağıdaki işlemleri yine de uygulayacaktır. Yeter ki içerisine parametre eklemiş olalım.

//parametrelere fonksiyon oluşturma esnasında eşittir diyip verdiğimiz değerler default değerlerdir. yani fonksyonu çağırdığımızda hiçbir değer vermezsek bile parametrelere, yine de çalışır ve içerisindeki default değerler üzerinden fonksiyon içerisindeki işlemleri gerçekleştirir.
// function sayiGoster(sayi1 = 0, sayi2 = 0) {
//   window.alert(sayi1 + sayi2);
// }

// sayiGoster(5, 2);

// function sayiGoster1(sayi1, sayi2) {
//   window.alert(sayi1 + sayi2);
// }

// sayiGoster1(2, 3);

// function sayiTopla(osman1, nuriye2) {
//   window.alert(osman1 + nuriye2);
// }

// var sayi1 = prompt("Lütfen birinci sayıyı giriniz");
// var sayi2 = prompt("Lütfen ikinci sayıyı giriniz");
// var sayi3 = prompt("Lütfen üçüncü sayıyı giriniz");

// sayiTopla(parseInt(sayi1), parseInt(sayi3));
// sayiTopla(5,7)

function sayiTopla2() {
  var x = parseInt(prompt("SAyi gir"));
  var y = parseInt(prompt("SAyi gir"));
  window.alert(x + y);
}

sayiTopla2();
