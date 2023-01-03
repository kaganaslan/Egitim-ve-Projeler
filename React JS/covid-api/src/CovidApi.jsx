import axios from "axios";
import React, { useEffect, useState } from "react";

function CovidApi() {
  // 1. Api verimizin linkini bir değişkende tuttuk.
  const CovidURL =
    "https://raw.githubusercontent.com/ozanerturk/covid19-turkey-api/master/dataset/timeline.json";

  //2. bu veriye erişim sağladığımızda değişikliklerin dinlenebilmesi için bir useState oluşturduk başlangıç halini boş array haline getirdik.
  const [veri, setVeri] = useState([]);
  const [tarih, setTarih] = useState("");

  //4. Tarih verisini tutmak için inputa onchange metodu ekleyip bunu fonksiyonlaştırarak. Yukarıda oluşturduğumuz tarih için çalışan useState içerisine setleme işlemini burada gerçekleştirdik. Artık 3. aşamadaki useEffect üzerinde veri gelirken tarih indeximizi dinamik olarak atama gerçekleştirebileceğiz. Fakat burada önemli olan kısım useEffect dependency'lerine bu tarih verisini koyabilmektir. Çünkü bu tarih verisini dependency bölümüne eklemezsek useEffect içerisindeki kod blokları sadece bir kere çalışacaktır.
  const tarihHandler = (e) => {
    const date = e.target.value;
    setTarih(date);
  };

  //3. aşama olarak yukarıda tanımladığımız API linkine erişmek için önce programımıza axios kurduk. Sonra da axios ile sayfa çalıştığı anda dataların gelmesi için get metodunu kullandık. Fakat gelen datanın önce console.log ile yazdırılmasını sağladık ve böylece dataların index numaralarının normalin dışında olarak tarihler halinde ayrılmış string yapılarından oluştuğunu konsolda gördük. Bu sebeple bize lazım olan bir tarih değişkenine ihtiyaç duyduğumuzu fark ettik. Ve htmlin input bölümündeki kullanıcının gireceği yazıyı onChange metodu vasıtasıyla tuttuk. Artık verimizi setlerken köşeli parantez içerisine tutacağımız bu tarih verisini girebiliriz.
  useEffect(() => {
    axios
      .get(CovidURL)
      .then((res) => setVeri(res.data[tarih]))
      .catch((err) => console.log(err));
  }, [tarih]);

  console.log("Tarihimiz: ", tarih);
  console.log("Tarihimize göre gelen veri: ", veri);
  return (
    <div className="text-center ">
      <h2>TÜRKİYE GÜNCEL COVİD İSTATİSTİKLERİ</h2>
      <input
        type="text"
        className="form-control my-3 w-50 m-auto"
        placeholder="GG/AA/YYYY"
        onChange={tarihHandler}
      />

      <table className="table table-dark  table-striped table-hover table-bordered w-75 m-auto">
        <thead>
          <tr>
            <th>Günlük Hasta Sayısı</th>
            <th>Toplam Hasta Sayısı</th>
            <th>Günlük Test Sayısı</th>
            <th>Toplam Test Sayısı</th>
            <th>Günlük Vefat Sayısı</th>
            <th>Toplam Vefat Sayısı</th>
          </tr>
        </thead>
        <tbody>
          {/* Burada ternary operator kullanma sebebimiz inputa henüz yazı yazmadığımız zaman bile axios veri çekmeye çalışıyor ve undefined cevabı alıyor bu yüzden table yüklenemiyor bu yüzden sayfamız yüklenemiyor :D */}
          {veri == undefined ? (
            <tr className="table-danger ">
              <td colSpan={6}>VERİ BEKLENİYOR</td>
            </tr>
          ) : (
            <tr className="table-info">
              <td>{veri.patients}</td>
              <td>{veri.totalPatients}</td>
              <td>{veri.tests}</td>
              <td>{veri.totalTests}</td>
              <td>{veri.deaths}</td>
              <td>{veri.totalDeaths}</td>
            </tr>
          )}
        </tbody>
      </table>
    </div>
  );
}

export default CovidApi;
