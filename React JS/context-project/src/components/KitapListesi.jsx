import axios from "axios";
import React, { useEffect, useState } from "react";
import { API_URL } from "../API";
import { useAppContext } from "../context/appContext";

function KitapListesi() {
  //gelen datayı useState aracılığıyla setleyeceğiz bu yüzden books adında bir useState kuralım.

  const [books, setBooks] = useState([]);

  //useEffect vasıtasıyla sayfamız yüklendiği anda axiosu çalıştırıp datalarımıza erişeceğiz.
  const { favoriler, favorilereEkle, favorilerdenSil } = useAppContext();

  //burada bir kitap favorilere eklenmiş mi eklenmememiş mi kontrolü yapacağız. eklendiyse favorilerden kaldır seçeneği çıkmasını istiyoruz.
  const favoriKontrol = (id) => {
    const secim = favoriler.some((favori) => favori.id == id);
    return secim;
  };

  //Şimdi oluşturmuş olduğumuz contexti sayfamıza çağıralım ve 3 adet propu kullanalım.

  useEffect(() => {
    axios
      .get(API_URL)
      .then((res) => setBooks(res.data))
      .catch((err) => console.log(err));
  }, []);
  console.log(books);
  var maxLength = 70;

  console.log("Favori Listesi", favoriler);

  return (
    <div className="container">
      <div className="kitaplar">
        <div className="row">
          {books.map((book) => {
            return (
              <div className="col-md-4 my-4">
                <div
                  className="card"
                  style={{ width: "auto", height: "430px" }}
                >
                  <div>
                    <img
                      src={book.image_url}
                      className="card-img-top img-fluid"
                      alt="..."
                      style={{
                        height: "150px",
                        width: "auto",
                        marginTop: "15px",
                      }}
                    />
                    <div className="card-body">
                      <h5 className="card-title">{book.title}</h5>
                      <p className="card-text">{book.authors}</p>
                      <p className="card-text">
                        {book.description.substr(
                          0,
                          book.description.substr(0, 60).lastIndexOf(" ")
                        )}
                        ...
                      </p>
                      {favoriKontrol(book.id) ? (
                        <button
                          className="btn  btn-danger favoributonu"
                          onClick={() => favorilerdenSil(book.id)}
                        >
                          Favorilerden Sil
                        </button>
                      ) : (
                        <button
                          className="btn  btn-warning favoributonu"
                          onClick={() => favorilereEkle(book)}
                        >
                          Favorilere Ekle
                        </button>
                      )}
                    </div>
                  </div>
                </div>
              </div>
            );
          })}
        </div>
      </div>
    </div>
  );
}

export default KitapListesi;
