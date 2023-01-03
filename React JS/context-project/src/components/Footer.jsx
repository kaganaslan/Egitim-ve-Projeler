import React from "react";

function Footer() {
  return (
    <div>
      <div className="container-fluid">
        <div className="footer">
          <div className="row">
            <div className="col-md-4 sol">
              <div className="row">
                <div className="col-md-4">
                  <i className="fa-brands fa-instagram"></i>
                </div>
                <div className="col-md-4">
                  <i className="fa-brands fa-youtube"></i>
                </div>
                <div className="col-md-4">
                  <i className="fa-brands fa-twitter"></i>
                </div>
              </div>
            </div>
            <div className="col-md-4 orta">
              Copyright 2022 <i className="fa fa-copyright"></i>
            </div>
            <div className="col-md-4 sag">
              <ul>
                <li>
                  <a href="">Anasayfa</a>
                </li>
                <li>
                  <a href="">Kitaplar</a>
                </li>
                <li>
                  <a href="">Favoriler</a>
                </li>
              </ul>
            </div>
          </div>
        </div>
      </div>
    </div>
  );
}

export default Footer;
