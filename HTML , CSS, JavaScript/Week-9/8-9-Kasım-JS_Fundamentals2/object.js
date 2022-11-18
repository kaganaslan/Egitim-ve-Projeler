// Objects

const calisan = {
  isim: "Barbaros",
  soyisim: "CİGA",
  yas: 30,
  adres: {
    sokak: "barbaros bulv",
    il: "İstanbul",
    mahalle: "Beşiktaş",
    ulke: "Turkey",
  },
  yetenekler: ["gitar", "davul", "resim"],
};
console.log(calisan);
console.log(calisan.isim);
console.log(
  `Çalışanımızın adı ${calisan.isim}, soyadı: ${calisan.soyisim} ve yaşı ${calisan.yas}'dır.`
);

console.log(calisan.yetenekler[1]);
console.log(calisan.adres.mahalle);

//Destruct etme
const {
  isim,
  yas,
  adres: { il },
} = calisan;
console.log(isim, yas, il);

calisan.email = "barb.ciga@gmail.com";

console.log(calisan);

const rockGruplari = [
  {
    id: 1,
    name: "Metallica",
    desc: "Trash Metal",
    concertInTurkey: false,
  },
  {
    id: 2,
    name: "KoRn",
    desc: "Nu Metal",
    concertInTurkey: true,
  },
  {
    id: 3,
    name: "Disturbed",
    desc: "Nu Metal",
    concertInTurkey: false,
  },
  {
    id: 4,
    name: "Blind Guardian",
    desc: "Power Metal",
    concertInTurkey: true,
  },
];

console.log(rockGruplari[3].name);
console.log(rockGruplari);
console.log(rockGruplari[2].desc);

//Object formatı JSON formatına çok benzeyen bir yapıdadır. API'lar genellikle json formatında yazıldığı için bizim de verilerimizi çekerken ya da gönderirken objectlerimizi json formatına convert etmemiz dönüştürmemiz çevirmemiz gerekebilir. bunu yapmak için JSON.stringify özelliğini kullanmaktayız.
const jsonYapilmisDosya = JSON.stringify(rockGruplari);
console.log(jsonYapilmisDosya);
