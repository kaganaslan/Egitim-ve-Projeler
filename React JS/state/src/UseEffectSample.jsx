import React, { useEffect, useState } from "react";

function UseEffectSample() {
  //useState hook'u vasıtasıyla tıpkı bir değişken tutar gibi ilgili nesnemiz ne ise onun kurulumunu return alanı ile function alanı arasında tanımlıyoruz. Ve useState parantezi içerisinde başlangıç değerini ( initial value ) atamasını yapıyoruz. kullanım şekli aşağıdaki gibi olup genel kullanımda sol tarafta son haliyle atanan değer, sağ tarafta da atamayı yapan değer bulunmaktadır. Yani biz return alanında herhangi bir yerde soldaki değere yani bir değer atmak istiyorsak onu setlememiz gerekmektedir. Bunu da setOrnek() diyerek parantezin içerisinde atamasını gerçekleştiriyoruz.
  const [number, setNumber] = useState(0);

  // useEffect hook'unun da çalışma mantığı şöyledir. Sayfamız render edildiği anda(yüklendiği) ilk çalışacak olan kod bloklarını belirttiğimiz alandır. Bu alanda fonksiyonları yazdıkdan sonra süslü parantezleri tamamlayıp akabinde virgül ile köşeli parantezler koyarak içerisinde dependencylistleri ekliyoruz. Nedir bu dependencylist dediğimiz şey? useEffect sayfa açıldığında sadece bir kerelik içerisinde yazan blokları çalıştırır fakat dependency bölümünde yazdığımız stateler içinde bir değişiklik gerçekleştirilirse tekrardan bu blokları çalıştırır. Yani her state değişikliği olduğunda parantezin içindeyse bu değerler, useEffect tekrardan çalışıyor.
  useEffect(() => {
    console.log("Use Effect Çalıştırıldı");
    document.title = `Toplam ${number} kere tıkladın`;
  }, [number]);

  return (
    <div>
      <div className="text-center my-3">
        <a>Toplam {number} kere tıkladın.</a>
      </div>
      <br />
      <button
        className="btn btn-dark my-2"
        onClick={() => setNumber(number + 1)}
      >
        TIKLA!
      </button>
    </div>
  );
}

export default UseEffectSample;
