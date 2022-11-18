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

document.getElementById("calisanGetir").addEventListener("click", calisanGetir);

// function calisanGetir() {
//   fetch("./employees.json")
//     .then((res) => res.json())
//     .then((data) => console.log(data))
//     .catch((error) => console.log(error));
// }

function calisanGetir() {
  fetch("./employees.json")
    .then((res) => res.json())
    .then((data) => {
      let cikti = '<h1 class="text-danger">Çalışan Listemiz</h1>';
      data.map(
        (calisan) =>
          (cikti += `
      <ul style="list-style-type:none">
      <li>ID: ${calisan.id}</li>
      <li>İsim: ${calisan.name}</li>
      <li>Soyisim: ${calisan.surname}</li>
      <li>Mail: ${calisan.email}</li>
      </ul>
      `)
      );
      document.getElementById("cikti").innerHTML = cikti;
    });
}

document.getElementById("apiGetir").addEventListener("click", apiGetir);

function apiGetir() {
  fetch("https://jsonplaceholder.typicode.com/posts")
    .then((response) => response.json())
    .then((veri) => {
      console.log(veri);
      let output = '<h1 class="text-danger">Gönderiler</h1>';
      veri.map(
        (api) =>
          (output += `
        <div class="bg-dark text-warning">
        <h3>${api.title}</h3>
        <p>${api.body}</p>
        </div>`)
      );
      document.getElementById("cikti").innerHTML = output;
    });
}

//form elementimize eriştik ve event ( olay ) olarak form elementindeki submit işlemini seçtik. Submit gerçekleştiği anda gonderi oluştur adında bir fonksiyon çalıştırdık. Bu fonksiyonu çalıştırırken ilk işlem olarak varsayılan tarayıcı davranışından kaçındık (preventDefault) bunu yapmasaydık gönderimizi oluşuramadan sayfayı yenileyeceği için verimizi tutamayacaktık. sonra başlık ve içerik için birer tanımlama yaptık. ve bu inputlara girdiğimiz değeri okuyabilmek için .value dedik ve girmiş olduğumuz verileri tuttuk.
// sonra post işlemi gerçekleştirmek için yine fetch metodunu çalıştırdık. fakat bu sefer get metodunu kullanmayacağımız için ikincil prametre olarak fetch'in metodunu tanımladık. Bu kısım sabittir internetten erişebilirsiniz. , koyduktan sonra method: "POST" yazıyoruz, headers bölümünü yazıyoruz(değiştirmeden), ve body kısmında post edilecek veri her ne ise onu belirtmemiz gerekiyor yani body demek post edilecek şey demektir.(bizdeki başlık ve post kısmı göndereceğimiz veriler olduğu için bodye bunları yazıyoruz.) Fakat önemli olan kısım şu ki, göndereceğimiz API'da bu iki verinin nereye ekleneceğini yani hangi özelliği dolduracağını belirtmeniz gerekiyor. yani bu örnekte gönderi başlığı API üzerinde title olark tanımlandığı için biz de title: baslik dedik yine gönderi içeriği body olarak tanımlandığı için biz de body: post dedik. bu noktadan sonra gerisi standart then.then diyerek devam eden kısımdır.
document
  .getElementById("gonderiOlustur")
  .addEventListener("submit", gonderiOlustur);

function gonderiOlustur(e) {
  e.preventDefault();

  let baslik = document.getElementById("title").value;
  let post = document.getElementById("body").value;

  fetch("https://jsonplaceholder.typicode.com/posts", {
    method: "POST",
    headers: {
      "Content-Type": "application/json",
    },
    body: JSON.stringify({ title: baslik, body: post }),
  })
    .then((response) => response.json())
    .then((data) => console.log(data));
}
