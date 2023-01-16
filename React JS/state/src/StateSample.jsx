import React, { useEffect, useState } from "react";

function StateSample() {
  const [sayac, setSayac] = useState(0);
  const [sayac2, setSayac2] = useState(0);

  const handleDecrease = () => {
    setSayac(sayac - 1);
  };

  useEffect(() => {
    setTimeout(() => {
      setSayac(sayac + 1);
    }, 1000);
  }, [sayac2]);
  return (
    <div>
      <div className="container my-5">
        <h1 className="text-danger">Sayaç</h1>
        <div className="card m-auto my-3" style={{ width: "18rem" }}>
          <div className="card-body">
            <h5 className="card-title">{sayac}</h5>

            <button
              className="btn btn-success mx-2"
              onClick={() => setSayac(sayac + 1)}
            >
              Arttır
            </button>
            <button className="btn btn-danger mx-2" onClick={handleDecrease}>
              Azalt
            </button>
          </div>
        </div>
      </div>

      <div className="container my-5">
        <h1 className="text-danger">Sayaç 2</h1>
        <div className="card m-auto my-3" style={{ width: "18rem" }}>
          <div className="card-body">
            <h5 className="card-title">{sayac2}</h5>

            <button
              className="btn btn-success mx-2"
              onClick={() => setSayac2(sayac2 + 1)}
            >
              Arttır
            </button>
            <button
              className="btn btn-danger mx-2"
              onClick={() => setSayac2(sayac2 - 1)}
            >
              Azalt
            </button>
          </div>
        </div>
      </div>
    </div>
  );
}

export default StateSample;
