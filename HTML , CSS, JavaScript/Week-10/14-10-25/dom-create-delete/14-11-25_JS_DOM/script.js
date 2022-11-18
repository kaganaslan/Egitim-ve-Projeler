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
// document.title = "Seda Öksürdü";
// console.dir(document.title);

// console.log(document.all[10]);

// document.all[10].textContent = "absürt";
// document modelimizin içinde bulunan all isimli birimde index numaraları verilmiş halde sayfamızda tasarlamış olduğumuz bütün elementlerimiz bulunmaktadır. Bu elemente index numarası vasıtasıyla erişip içerisinde bulunan yazıyı textContent metodu ile değiştirebilmekteyiz.
// document.all[10].textContent = "Objeler";

// console.log(document.forms);

//Dökümanımızın içinde bulunan elementlere bu elementlere ait id numaraları vasıtasıyla nasıl erişmekteyiz???

// let headerTitle = document.getElementById("header-baslik");
// console.log(headerTitle);

// headerTitle.textContent = "JS DOM Maniplasyonu";

// console.log(headerTitle.textContent);
// console.log(headerTitle.innerText);
// headerTitle.innerText = "js dom maniplasyonu2";
// headerTitle.innerText = headerTitle.innerText + " sdsadasd";

//inner text ile text content arasındaki fark text content ile kullanıcı arayüzünde gözükmeyen yazılar da erişilebilir haldedir. fakat innertext kullanımında sadece kullanıcı arayüzünde görürnen text ifadelerine erişim sağlayabiliriz.
// console.log(headerTitle.textContent);
// console.log(headerTitle.innerText);

//Peki inner HTML Nedir? //15 dk sonra...
// headerTitle.innerHTML = '<h2 class="text-danger"> JS DOM Maniplasyonu </h2>';
// headerTitle.innerHTML += "<h3>İkinci Başlık</h3>";
// headerTitle.style.borderBottom = "5px solid springgreen";
// headerTitle.style.padding = "0 10px";
// headerTitle.style.fontWeight = 700;

// Class isimlerine göre element erişimi
// let nesneler = document.getElementsByClassName("list-group-item");

// console.log(nesneler);
// console.log(nesneler[1]);

// for (let index = 0; index < nesneler.length; index++) {
//   nesneler[index].style.backgroundColor = "darkgray";
// }

// nesneler[1].style.backgroundColor = "springgreen";
// nesneler[1].style.color = "black";
// nesneler[1].style.fontWeight = "bold";
// nesneler[1].style.borderBottom = "2px solid black";

//Tag name lere göre elementleri çağırma

// direkt olarak istenen element adı da aratılarak getelementsbytagname kullanımı bile bir collection şeklinde sıralanarak getirilecektir.
// var liItems = document.getElementsByTagName("li");
// console.log(liItems);

// for (let i = 0; i < liItems.length; i++) {
//   liItems[i].style.fontWeight = "bold";
//}

// QUERY SELECTOR

// var baslik = document.querySelector("#ana-header");
// console.log(baslik);

// baslik.style.border = "2px solid orange";

// let veriGiris = document.querySelector("input");
// console.log(veriGiris);
// veriGiris.placeholder = "html dom öğreniyorum.";
// veriGiris.value = "html dom öğreniyorum.";

// var buton = document.querySelector('input[type="submit"]');
// console.log(buton);
// buton.value = "YOLLA!";

//tekli nesne çağırımı - ilk elemanı getirir.
// var nesne = document.querySelector(".list-group-item");
// console.log(nesne);

//son nesneyi çağırmak
// var sonNesne = document.querySelector(".list-group-item:last-child");
// console.log(sonNesne);

// ikinci elemanı getirelim
// var ikinciCocuk = document.querySelector(".list-group-item:nth-child(2)");
// console.log(ikinciCocuk);

//query selector all
// var biseyler = document.querySelectorAll(".main-title");
// console.log(biseyler);
// var nesnelerfull = document.querySelectorAll(".list-group-item");
// console.log(nesnelerfull);

// var tekler = document.querySelectorAll("li:nth-child(odd)");
// console.log(tekler);
// var ciftler = document.querySelectorAll("li:nth-child(even)");
// console.log(ciftler);

// for (let index = 0; index < tekler.length; index++) {
//   tekler[index].style.backgroundColor = "red";
// }

// for (let index = 0; index < ciftler.length; index++) {
//   ciftler[index].style.backgroundColor = "white";
// }

//çocuk ebeveyn

// var nesneListe = document.querySelector("#nesneler");
// console.log(nesneListe);

//parent node özelliği bize mevcut elementi kapsayan üst ebeveyn elemente erişim sağlamamızı sağlamaktadır.
// console.log(nesneListe.parentNode);
// nesneListe.parentNode.style.backgroundColor = "orange";

//child nodes kullanımı ile de alt elementlere erişim sağlıyoruz fakat burada sadece elementler değil içerisindeki textler de bizlere sunulmaktadır o yüzden doğru index numarası kullanımı ile doğrudan elemente erişim sağlayaibliriz.
// console.log(nesneListe.childNodes[1]);
// ilk alt elementi de firstElement Child kullanarak doğrudan çağırabiliyoruz.
// console.log(nesneListe.firstElementChild);
// console.log(nesneListe.lastElementChild);
// nesneListe.lastElementChild.textContent = "Selam ben son nesne";

// console.log(nesneListe.nextElementSibling);
// console.log(nesneListe.previousElementSibling);

//YENİ DİV OLUŞTURMA

// let yeniDiv = document.createElement("div");

//dive id verme
// yeniDiv.id = "yeniDivID";

//özellik - Attribute ekleme
// yeniDiv.setAttribute("baslik", "yeniDivAttrDeger");

// var yeniDivText = document.createTextNode("Selamlar ben yeni div");

//yeni dive yeni texti atamak
// yeniDiv.appendChild(yeniDivText);

// console.log(yeniDiv);

// var konteynir = document.querySelector("header .container");
// console.log(konteynir);
// var headerh2 = document.querySelector("header h2");

//eğer belli bir alandan önce ekleme yapmak istiyorsak insert before komutu ile ekleme ypabiliyoruz
// konteynir.insertBefore(yeniDiv, headerh2);

// fakat ilgili alanın içindeki en son elementten sonra bir element eklemesi yapacaksak appendChild'ı kullanıyoruz.
// konteynir.appendChild(yeniDiv);

// eventler. click eventi.

// var buton = document.querySelector("#buton").addEventListener("click", tiklama);

// function tiklama() {
//   document.getElementById("header-baslik").textContent = "Tıklama Eventi";
//   document.getElementById("main").style.backgroundColor = "blueviolet";
// }

// var secim = document.querySelector("select");

// secim.addEventListener("change", olay);

// function olay(e) {
//   console.log(e.target);
//   console.log(e.target.value);
// }

// var input1 = document.querySelector("#nesne");
// input1.addEventListener("change", olay);

// var kutu = document.querySelector("#kutu");
// var cikis = document.querySelector("#cikis");

// kutu.addEventListener("mouseenter", mousefunc);
// kutu.addEventListener("mouseleave", mousefunc);
// kutu.addEventListener("mouseover", mousefunc);
// kutu.addEventListener("mouseout", mousefunc);
// kutu.addEventListener("mousemove", mousefunc);
// function mousefunc(e) {
//   console.log("Olayımız " + e.type);
//   cikis.innerHTML = `<h3> X ekseni:
//     ${e.offsetX}
//     </h3><h3> Y Ekseni:
//     ${e.offsetY}
//     </h3>`;
// }
