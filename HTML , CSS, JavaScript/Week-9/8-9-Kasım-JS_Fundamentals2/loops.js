// FOR DÖNGÜSÜ

// for (let i = 0; i < 5; i++) {
//   console.log(i);
// }

/*for(let başlatıcı değer = değer; koşul; işlem){
kod blokları işlemler vs.
}
*/

// let mesaj = prompt("Lütfen bir metin giriniz");
// let tekrar = parseInt(prompt("Lütfen tekrar sayısını giriniz"));

// for (let index = 0; index < tekrar; index++) {
//   window.alert(mesaj);
// }

// var arr = [];
// for (let index = 0; index < 100; index++) {
//   if (index % 3 == 0) {
//     arr.push(index);
//   }
// }
// console.log(arr);

//WHILE - DO WHILE

// let i = 0;
// while (i < 10) {
//   console.log(i);
//   i++;
// }

// do {
//   console.log(i);
// } while (i < 10);

// while (true) {
//   var x = prompt("Lütfen Bir Sayı Giriniz");
//   if (x < 10) {
//     window.alert("Sayı 10'dan küçük");
//     var cikis = prompt("Çıkmak istiyor musunuz?").toLowerCase();
//     if (cikis == "evet") {
//       break;
//     }
//   } else {
//     window.alert("Sayı 10'dan büyük veya eşit");
//     var cikis = prompt("Çıkmak istiyor musunuz?").toLowerCase();
//     if (cikis == "evet") {
//       break;
//     }
//   }
// }

const islemler = [
  {
    id: 1,
    islem: "Uyan",
    yapildimi: true,
  },
  {
    id: 2,
    islem: "Kahvaltı Yap",
    yapildimi: true,
  },
  {
    id: 3,
    islem: "Derse gir",
    yapildimi: true,
  },
  {
    id: 4,
    islem: "Öğle Yemeği Ye",
    yapildimi: false,
  },
];

//iterasyonel bir for kullanımı

// for (let x of islemler) {
//   console.log(x);
// }

// for (let x of islemler) {
//   console.log(x.yapildimi);
// }

//foreach
//foreach döngüsü kullanılarak fonksiyonel döngü işlemleri yapma imkanımız bulunmaktadır. Burada dikkat etmemiz gereken konu functiona parametre olarak girdiğimiz hayali değeri function scope'u içerisinde geri çağırmaktır(callback). Bu işleme call back denir. ve böylece döngü döndüğü sürece function çalışır.

islemler.forEach(function (islem) {
  console.log(islem.islem);
});

//map
// map işlemi tıpkı foreach gibi döngüsel işlemleri fonksiyonel olarak kullanmamıza yarar. forEachten farkı bize bir return değeri verebilmesidir.

const islemlerIslem = islemler.map(function (todo) {
  return todo.islem;
});

console.log(islemlerIslem);

//filter

const todoList = islemler.filter(function (todo) {
  return todo.yapildimi === true;
});

console.log(todoList);

// filter işlemi belirttiğimiz seçeneklere göre ilgili datadan istediğimiz özelliklere göre yeni bir array döndürür.

const todoListe = islemler
  .filter(function (todo) {
    return todo.yapildimi === true;
  })
  .map(function (yapilacak) {
    return yapilacak.id;
  });

console.log(todoListe);
