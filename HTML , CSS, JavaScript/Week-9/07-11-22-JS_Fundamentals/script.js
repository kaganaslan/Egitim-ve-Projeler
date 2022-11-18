// console.log("s.a");
// window.alert("S.A");
// prompt("yazın");

// yorum satırı
/*
Çoklu
Yorum
Satırı
*/

// Örnek Yazımızı Yazdık

//Data Tipleri
//undefined, string, boolean, Number, object, null

//Değişken Nasıl Tanımlanır??
// var, let ve const

// const pi = 3.14;
// console.log(pi);

// let sayi = prompt("Lütfen Bir Sayı Giriniz");
// console.log(sayi);
// var mesaj = "Girmiş olduğunuz ifade " + sayi;
// window.alert(`Girilmiş olan sayı ${sayi}`);
// console.log("Girilmiş olan ifade: " + sayi);
// console.log(mesaj);

// var name = "Barbaros";
// var surname = "CİGA";
// let age = 30;
// const sabit = 15;

// console.log(name, surname, age, sabit);
// name = "Seda";
// surname = "Sever";
// sabit = 17;
// var name = "Kağan";
// var surname = "Aslan";

//Değişken atamaları yaparken başında kullanmış olduğumuz tip yani (var,let, const) arasında belli farklar bulunmaktadır. const sabit ifadeler için kullanılmaktadır. Daha sonrasında değeri değiştirilemez. Let ve Var arasındaki şuan bildiğimiz fark üst kod bloklarında var ile tipi belirtilen bir değişken ataması yapıldıktan sonra alt bloklarda tekrar var ön ekiyle aynı değişkene yeni bir değer atabiliyorken, aynı işlem let ile gerçekleştirilemez. Yani örneğin üst kodlarda let x = 5; dendikten sonra alt kodlarda let x = 10 diyemezsiniz bunun yerine tıpkı c#'taki gibi x = 10; diyerek değerini güncellemiş olursunuz.
// let age = 25;
// console.log(name, surname, age, sabit);

//Değişken oluşturma yöntemleri;
// değişken oluşturulurken değer atamak.
// var x = 5;

// değişkeni oluşturup değeri daha sonra da atayabiliyoruz.
// var y;
// let z;
// console.log(x);
// console.log(y);
//önceden ram bellekte tanıtımını yapmış olduğumuz y değişkenin alt satırlrda değer atayabiliyoruz.
// y = 25;

// z = y;
// console.log(x, y, z);

// z = 6;
// f = "6";

// JS eşitlik kontrollerinde karar yapıları gibi kullanımlarda eşittir işareti üç eşittir ve iki eşittir olarak kullanılır. iki eşittir kullanımı yapıldığı zaman değer string de olsa number da olsa aynı datayı veriyorsa eşit kabul edilir, fakat kontrol üç eşittir ifadesiyle sağlanıyorsa tipleri farklı ise değer aynı ise false döner yani eşitlik sağlanmaz.
// console.log(typeof z, typeof f);
// console.log(z === f);

//JS Case Sensitive. Büyük Küçük Harf Duyarlıdır.
// let hocaninAdi = "Barbaros";
// console.log(hocaninadi); // outout alamayız. hata verir.

//Değişken oluşturma kurallı. Değişken isminin başında rakam kullanılmaz sonunda ya da içinde kullanılabilir..
// let 2falan = 15; --> oluşturulamaz
// let degisken2 = 15;

//Özel ifadeler de aynı şekilde kullanılamaz. Yalnızca _ kullanılabilir.

// let b.asd = 35 --> oluşturulamaz
// let _sayi = 35

//Örnek bool tipinde değer atama
// let tenefus20DakikaMi = true;
// let isAdmin = false;
// console.log(isAdmin);

// const kisiler = ["Ahmet", "Mehmet", "Fikret", "Saffet", "Erdem", "Adem", 35];
// console.log(kisiler);
// console.log(typeof kisiler);

// document.getElementById("deneme").innerHTML = "<h3> Vaaaaov </h3>";

//Matematiksel Operatörler

// var a = 10;
// let k = 22;

// var toplam = 15 + 26;
// toplam = a + k;
// console.log(a + k);
// console.log(toplam);

// console.log(a - k);

// console.log(a / k);

// console.log(a * k);

// console.log(a ** 2);

// console.log(a % 10);

// a = a + 1
// a++;
// console.log(a);

// a--;
// console.log(a);

// const ondalikli = 5.17;
// console.log(ondalikli);

// kaçış ifadeleri

var mesaj =
  "Merhaba Wissen 304 sınıfında Full Stack Web Development Eğitimi verilmektedir.";
console.log(mesaj);

let mesaj2 =
  'Merhaba "Wissen 304" sınıfında Full Stack Web Development Eğitimi verilmektedir.';
console.log(mesaj2);

let mesaj3 = `Merhaba "Wissen 304" sınıfında Full Stack Web Development Eğitimi verilmektedir.`;
console.log(mesaj3);

let mesaj4 =
  "Merhaba 'Wissen 304' sınıfında Full Stack Web Development Eğitimi verilmektedir.";

console.log(mesaj4);

var stringifade = '<a href="www.google.com"></a>';
console.log(stringifade);
var stringifade2 = `<a href=\"www.google.com\"></a>`;
console.log(stringifade2);

// "\t"  bir tab kadar boşluk verir.
// "\n"  bir satır aşağı iner
// "\" bunu zaten kullandık. :):):)

// String concatination -- string birleştirme

//1- plus operator
var adim = "Barbaros ";
var soyadim = "CİGA";
var fullName = adim + soyadim;
console.log(fullName);

var mesajim =
  "Merhaba" +
  " " +
  adim +
  "benim adım ve soyadim " +
  soyadim +
  " memnun oldum.";
console.log(mesajim);

let baslangic = "Selam ";
let final = "Ben Barbaros";

baslangic += final;
console.log(baslangic);

console.log(baslangic.length);
console.log(baslangic[0]);
console.log(baslangic[baslangic.length - 1]);

// stringlerdek immutable meselesi

//string ifadelerde ifade doğrudan deiştirilebilir. Fakat index numarasına erişip bunu dğeiştirmeye müsade etmez.
var yaziliMetin = "Seda Sever Bize Mandalina Uzattı";
yaziliMetin = "Sefa Sever Bize Mandalina Uzattı";
console.log(yaziliMetin);
yaziliMetin[2] = "d";
console.log(yaziliMetin);

//Arrays

//söz dizimi bildiğimiz şekildedir.

const arabalar = ["BMW", "Mercedes", "Saab"];
console.log(arabalar[1]);

//nested array --> array içinde array tanımlaması
const myArray = [
  ["Barbaros", 30],
  ["Seda", 24],
  ["Kağan", 25],
  ["Selin", 24],
];

console.log(myArray);
console.log(myArray[3][1]);

const myArray3 = [
  [
    ["Barbaros", "Ciga", 30],
    ["Kağan", "Aslan", 25],
    ["Selin", "Bayatlı", 24],
    ["Seda", "Sever", 24],
  ],
  [
    ["İzmir", 35],
    ["Sinop", 57],
    ["Çorum", 19],
    ["RİZE", 53],
  ],
];

console.log(myArray3);
console.log(myArray3[1][1][1]); // 57yi verir.

//ARRAY METOTLARI

// Diziye Eleman Ekleme

var dizi = ["Muhittin", "Sucuk", "Elmas", "Kalpazan"];
console.log(dizi);
dizi.push("Müzik");
console.log(dizi);

dizi[0] = "Fazıl";
console.log(dizi);

//Son elemanı silme
let dizi1 = [1, 2, 3, 4];
console.log(dizi1);
dizi1.pop();
console.log(dizi1);

//İlk elemanı silme
dizi1.shift();
console.log(dizi1);

let dizi3 = ["Ali Rıza", "Ferhunde", "Şevket", "Leyla", "Necla", "Oğuz"];

console.log(dizi3);

//birinci elemanı değiştirme
dizi3.unshift("Mesut Komser");
console.log(dizi3);

//Dizi index numaralarını terse çevirme
dizi3.reverse();
console.log(dizi3);
//Diziyi sıralama (alfanumerik)
dizi3.sort();
console.log(dizi3);

// Delete komutu index numarasını sabit tutar sadece içinde kayıtlı değeri siler dolayısıyla sadece o indxe erişim sağlanmaya çalışıldığında içerik olarak undefined alırız, bütün diziyi çalıştırırsak o bölgenin boş olduğu gözükür.
delete dizi3[0];
console.log(dizi3);
dizi3[0] = "Habeş Maymunu";
console.log(dizi3);

//Array Concatination --
//1) Array concat
var dizi4 = ["Muz", "Hıyar"];
var dizi5 = ["Elma", "Kamkat"];
var dizi6 = ["Siber", "Eşkal"];

const newDizi = dizi4.concat(dizi5);
console.log(newDizi);

//2) Array Merge

const newArray = dizi4.concat(dizi5, dizi6);
console.log(newArray);

// Splice Metodu
//splice metodu ile dizide istediğimiz index numarasından itibaren başlayıp eleman ekleme işlemlerini gerçekleştirebilmekteyiz. Bunun için önce ekleyeceğimiz içeriğin eklenecek dizideki index numarasını giriyoruz, ikinci parametre olarak eklenecek diziden kaç eleman silineceğini belirtiyoruz, sonra da ekleyeceğimiz elemanları yazıyoruz.
const array7 = ["Sabıka", "Huzurevi", "Üzüm", "Kitap", "Ümit Besen"];
array7.splice(2, 0, "Fırtına", "Örümcek Adam");
console.log(array7);
//istediğimiz indexe gidip oradan itibaren kaç tane eleman silmek istiyorsak bu şekilde yapıyoruz.
array7.splice(2, 1);
console.log(array7);

//String Metotları

var str1 = "BArbaros ciga";
let str2 = "     barb.ciga@gmail.com     ";
let str3 =
  "Benim adım Kağan Aslan. Tatilimi Namazgah dağlarında yapmayı severim.";
var num1 = 457;
console.log(str1.toUpperCase());
console.log(str1.toLowerCase());
console.log(num1.toString());
console.log(str1.length);
console.log(str1.slice(3, 6));
console.log(str1.slice(5));
console.log(str1.slice(-5));
console.log(array7.toString());
console.log(array7.toString().replaceAll(",", " "));
console.log(str2.trimEnd());
console.log(str2.trimStart());
console.log(str2.trim());
console.log(str3.split(" "));
console.log(str3.indexOf("Kağan"));
console.log(str3.lastIndexOf("a"));
console.log(str3.search("ğan"));
console.log(str3.substring(13));
console.log(str3.substring(13, 15));
console.log(str3.substr(13, 15));
console.log(str3.endsWith("."));
console.log(str3.startsWith("."));
console.log(str3.includes("ğa"));
console.log(str3.repeat(2));

let mail = "selin.corum@gmail.com";
let noktanerde = mail.indexOf(".");
console.log(noktanerde);
let mailnerde = mail.indexOf("@");
console.log(mailnerde);
// let newMail = mail.slice(5, 11, "bayatli");
// console.log(newMail);
let newMail = mail.replace(".corum", ".bayatli");
console.log(newMail);
