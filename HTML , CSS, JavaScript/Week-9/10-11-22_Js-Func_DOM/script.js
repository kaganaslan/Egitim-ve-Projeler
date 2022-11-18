// DOM YAPISI

/*
Açılımı docment object model'dan gelmektedir. HTML Sayfalarımızda döküman içerisinde bulunan objelerimize ( body, head, h1) kolay erişim sağlanması ve üzerinde işlemler yapılarak manipüle edilmesini sağlayan yapıdır.

DOM vasıtasıyla HTML sayfamızda bulunan HER ŞEYE erişim sağlayabiliriz.


html etiketi dahil tüm etiketler ve tüm elementlerin kapsayıcısı document modelidir.
Bu yapıdaki hiyerarşinin en ucu html ile başlar. Sonra head ve body olarak ayrılır. ve bunlar da kendi içerisinde ayrılırlar. yani aynı segmentte bulunabildikleri gibi parent ve child olma özellikleri de vardır. 

Node kavramı burada devreye girmektedir. (düğüm)

<head>
</head>
<body>
</body>

HTML içindeki bütün elementler birer düğümdür. Yukarıdaki head ve body gibi. Bu iki düğüm html düğümü yani node'u altında bulundukları için html node'unun çocuklarıdır.  aynı tag ya da aynı düğüme tabi oldukları için de birbirlernin kardeşleridir.

*/

// console.log(document);
// console.dir(document);
// console.dir(document.domain);
// console.dir(document.title);

//JS dosyası üzerinden değeri html sayfası içinde verilmiş olan title tagine erişip değerini atayabildik.
// document.title = "304";
// console.dir(document.title);

// console.log(document.all[10]);

// document modelimizin içinde bulunan all isimli birimde index numaraları verilmiş halde sayfamızda tasarlamış olduğumuz bütün elementlerimiz bulunmaktadır. Bu elemente index numarası vasıtasıyla erişip içerisinde bulunan yazıyı textContent metodu ile değiştirebilmekteyiz.
// document.all[10].textContent = "Objeler";

// console.log(document.forms);

//Dökümanımızın içinde bulunan elementlere bu elementlere ait id numaraları vasıtasıyla nasıl erişmekteyiz???

let headerTitle = document.getElementById("header-baslik");
console.log(headerTitle);

// headerTitle.textContent = "JS DOM Maniplasyonu";

// headerTitle.innerText = "js dom maniplasyonu2";
// headerTitle.innerText = headerTitle.innerText + " sdsadasd";

//inner text ile text content arasındaki fark text content ile kullanıcı arayüzünde gözükmeyen yazılar da erişilebilir haldedir. fakat innertext kullanımında sadece kullanıcı arayüzünde görürnen text ifadelerine erişim sağlayabiliriz.
console.log(headerTitle.textContent);
console.log(headerTitle.innerText);

//Peki inner HTML Nedir? //15 dk sonra...
headerTitle.innerHTML = '<h2 class="text-danger"> JS DOM Maniplasyonu </h2>';
headerTitle.innerHTML += "<h3>İkinci Başlık</h3>";
headerTitle.style.borderBottom = "5px solid springgreen";
headerTitle.style.padding = "0 10px";
headerTitle.style.fontWeight = 700;

// Class isimlerine göre element erişimi
let nesneler = document.getElementsByClassName("list-group-item");

console.log(nesneler);
console.log(nesneler[1]);

for (let index = 0; index < nesneler.length; index++) {
  nesneler[index].style.backgroundColor = "darkgray";
}

nesneler[1].style.backgroundColor = "springgreen";
nesneler[1].style.color = "black";
nesneler[1].style.fontWeight = "bold";
nesneler[1].style.borderBottom = "2px solid black";

//Tag name lere göre elementleri çağırma

// direkt olarak istenen element adı da aratılarak getelementsbytagname kullanımı bile bir collection şeklinde sıralanarak getirilecektir.
var liItems = document.getElementsByTagName("li");
console.log(liItems);

for (let i = 0; i < liItems.length; i++) {
  liItems[i].style.fontWeight = "bold";
}

// QUERY SELECTOR

var baslik = document.querySelector("#ana-header");
console.log(baslik);

baslik.style.border = "2px solid orange";

let veriGiris = document.querySelector("input");
console.log(veriGiris);
veriGiris.placeholder = "html dom öğreniyorum.";
veriGiris.value = "html dom öğreniyorum.";

var buton = document.querySelector('input[type="submit"]');
console.log(buton);
buton.value = "YOLLA!";

//tekli nesne çağırımı - ilk elemanı getirir.
var nesne = document.querySelector(".list-group-item");
console.log(nesne);

//son nesneyi çağırmak
var sonNesne = document.querySelector(".list-group-item:last-child");
console.log(sonNesne);

// ikinci elemanı getirelim
var ikinciCocuk = document.querySelector(".list-group-item:nth-child(2)");
console.log(ikinciCocuk);
