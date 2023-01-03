import React from "react";

function Welcome(props) {
  return (
    <div className="text-center">
      <div className="card m-auto" style={{ width: "18rem" }}>
        <img src={props.foto} className="card-img-top" alt="..." />
        <div className="card-body">
          <h5 className="card-title">Kullanıcı Adı: {props.ad}</h5>
          <p className="card-text">Meslek: {props.meslek}</p>
          <p className="card-text">Okul: {props.okul}</p>
          <p className="card-text">Yaş: {props.yas}</p>
          <p className="card-text">Memleket: {props.memleket}</p>
          <a href="#" className="btn btn-primary">
            Go somewhere
          </a>
        </div>
      </div>
    </div>
  );
}

export default Welcome;
