//DATE METHODS

// var name = "Seda";
// console.log(name);

var tarih = new Date();
console.log(tarih);

console.log(tarih.getDay());

const gunler = [
  "Pazar",
  "Pazartesi",
  "Salı",
  "Çarşamba",
  "Perşembe",
  "Cuma",
  "Cumartesi",
];

console.log(gunler[tarih.getDay()]);

//getMonth ile aldığınız sonuç 0-11 arasında bir number döndürür. Bu yüzden bulunduğunuz ayın gösterilmesi için üzerine bir eklemeniz gerekebilir.
console.log(tarih.getMonth());
console.log(tarih.getHours());
console.log(tarih.getFullYear());
console.log(tarih.getMinutes());
console.log(tarih.getSeconds());

console.log(tarih.getTime());

const aylar = [
  "Ocak",
  "Şubat",
  "Mart",
  "Nisan",
  "Mayıs",
  "Haziran",
  "Temmuz",
  "Ağustos",
  "Eylül",
  "Ekim",
  "Kasım",
  "Aralık",
];
console.log(aylar[tarih.getMonth()]);

var d = new Date("2025,10,15");
console.log(d);
var d2 = new Date("September 05,2022 01:00:19");
console.log(d2);
var d3 = new Date(2022, 10, 27, 10, 45, 35);
console.log(d3);

const year = tarih.getFullYear();
const month = (tarih.getMonth() + 1).toString();
const day = tarih.getDate();
const saat = tarih.getHours();
const dakka = tarih.getMinutes();
const saniye = tarih.getSeconds();

var goster = `${day}/${month}/${year} || ${saat}:${dakka}:${saniye}`;
console.log(goster);

// MATH METHODS

var num = 5;

//stringe dönüştürme
console.log(num.toString());

var num1 = 50.739;
// to fixed komutu ondalıklı kısmı yuvarlar girilen parametre kadar olan bir kısmı gösterir.
console.log(num1.toFixed(0));
console.log(num1.toFixed(1));
console.log(num1.toFixed(2));

// to precision ile tam sayı kısmı da dahil olarak parametre kadar kısım gösterir.
var num2 = 30.456;
console.log(num2.toPrecision(3));

console.log(Number("10a"));

console.log(Math.floor(2.6)); // floor her zaman aşağıya yuvarlar
// round metodu ondalık rakam 5ten yukarıdaysa yukarı yuvrlar aşağıdaysa aşağı yuvarlar
console.log(Math.round(2.3));
// ceil metodu sayıyı yukarı yuvarlar
console.log(Math.ceil(2.1));
// mutlak değer
console.log(Math.abs(-500));

//belirlenen aralıkta random değer atama
console.log(Math.round(Math.random() * (80 - 40) + 40));

console.log(5 ** 2);
console.log(Math.pow(5, 2));

console.log(Math.min(5, 100, -6, 55));
