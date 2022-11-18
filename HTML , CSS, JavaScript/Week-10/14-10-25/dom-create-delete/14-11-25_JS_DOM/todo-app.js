var formumuz = document.querySelector("#ekle");
// console.log(formumuz);
var ul = document.querySelector("#nesneler");

formumuz.addEventListener("submit", kaydet);

ul.addEventListener("click", silmefunc);

function kaydet(e) {
  //tarayıcının submit işlemi yapılırkenki default yani varsayılan ayarlarından kaçınmak için preventDefault özelliğini kullandık.
  e.preventDefault();
  //nesne idsine sahip olan veri girişi yaptığımız inputa erişim sağladık. nokta value diyerek input içerisine yazılmış olan değeri newıtem ismiyle tuttuk.
  var newItem = document.getElementById("nesne").value;
  console.log(newItem);
  //yeni bir li elemanı oluşturmak için ilk adım olan liItem nesnesini oluşturduk.
  var liItem = document.createElement("li");
  // yeni oluşturulacak olan li nesnemize class ataması yapıyoruz.
  liItem.className = "list-group-item";
  console.log(liItem);
  //şimdi newItem'ımımızı liItem'ın içerisine yollamamız gerekiyor. Append child diyip akabinde sadece new item'ı içerisine yolladığımız zaman bir node hatası almaktayız. Bunun çözümü için append child dedikten sonra document.createTextNode diyerek yeni text değerimizi ilgili li elementinin içerisine eklemiş olduk.
  //   liItem.appendChild(document.createTextNode(newItem));
  liItem.textContent = newItem;

  var silmeButon = document.createElement("button");
  silmeButon.className = "btn btn-danger float-end delete";
  silmeButon.textContent = "X";

  liItem.appendChild(silmeButon);
  console.log(liItem);

  ul.appendChild(liItem);
}

//silme
function silmefunc(e) {
  if (e.target.classList.contains("delete")) {
    if (confirm("Emin miyiz?")) {
      var liItem = e.target.parentElement;
      console.log(liItem);
      ul.removeChild(liItem);
    }
  }
}
