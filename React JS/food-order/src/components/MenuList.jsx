import React, { useState } from "react";
import Modal from "react-bootstrap/Modal";

function MenuList({ menu }) {
  const [show, setShow] = useState(false);

  const handleClose = () => setShow(false);
  const handleShow = () => setShow(true);

  const [miktar, setMiktar] = useState(1);
  const [ozellik, setOzellik] = useState("small");

  return (
    <div>
      <div
        className="card m-auto my-3 shadow-lg p-3 mb-5 bg-body-tertiary rounded"
        style={{ width: "23rem", height: "450px" }}
      >
        <div onClick={handleShow} style={{ cursor: "pointer" }}>
          <img
            src={menu.img}
            className="card-img-top img-fluid"
            alt="..."
            style={{ width: "200px" }}
          />
        </div>

        <div className="card-body">
          <h4 className="card-title">{menu.ad}</h4>
        </div>
        <div className="container">
          <div className="row">
            <div className="col-md-6">
              <p className="text-center">Özellikler</p>
              <select
                className="form-select"
                onChange={(e) => setOzellik(e.target.value)}
              >
                {menu.ozellik.map((varient) => (
                  <option value={varient}>{varient}</option>
                ))}
              </select>
            </div>
            <div className="col-md-6">
              <p className="text-center">Miktar</p>
              <select
                className="form-select"
                onChange={(e) => setMiktar(e.target.value)}
              >
                {[...Array(10).keys()].map((x) => (
                  <option value={x + 1}>{x + 1}</option>
                ))}
              </select>
            </div>
          </div>
        </div>
        <div className="container">
          <div className="w-100">
            <h5 className="my-2 text-danger ">
              Fiyat: {menu.fiyat[0][ozellik] * miktar} ₺
            </h5>
          </div>
          <div className="w-100">
            <button className="btn btn-warning w-100">Sepete Ekle</button>
          </div>
        </div>
      </div>

      <Modal show={show} onHide={handleClose}>
        <Modal.Header closeButton>
          <Modal.Title>{menu.ad}</Modal.Title>
        </Modal.Header>
        <Modal.Body>
          <img
            src={menu.img}
            className="img-fluid "
            style={{ height: "300px" }}
            alt=""
          />
          <h3 className="text-danger">Kategori: {menu.kategori}</h3>
          <p>{menu.desc}</p>
        </Modal.Body>
        <Modal.Footer>
          <button className="btn btn-danger w-100" onClick={handleClose}>
            Kapat
          </button>
        </Modal.Footer>
      </Modal>
    </div>
  );
}

export default MenuList;
