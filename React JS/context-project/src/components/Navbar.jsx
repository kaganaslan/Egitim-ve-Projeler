import React from "react";
import { useAppContext } from "../context/appContext";

function Navbar() {
  const { favoriler } = useAppContext();
  return (
    <div>
      <nav className="navbar navbar-dark bg-dark navbar-expand-lg ">
        <div className="container-fluid">
          <a className="navbar-brand" href="#">
            Kitap Proje
          </a>
          <button
            className="navbar-toggler"
            type="button"
            data-bs-toggle="collapse"
            data-bs-target="#navbarNav"
            aria-controls="navbarNav"
            aria-expanded="false"
            aria-label="Toggle navigation"
          >
            <span className="navbar-toggler-icon" />
          </button>
          <div className="collapse navbar-collapse" id="navbarNav">
            <ul className="navbar-nav">
              <li className="nav-item">
                <a className="nav-link active" aria-current="page" href="#">
                  Home
                </a>
              </li>
            </ul>
            <ul className="navbar-nav ms-auto">
              <li className="nav-item">
                <a className="nav-link" href="#">
                  Favoriler{" "}
                  <span
                    class="position-absolute top-2 start-80 translate-middle badge rounded-pill bg-warning"
                    style={{ right: "-10px", color: "black" }}
                  >
                    {favoriler.length}
                    <span class="visually-hidden">unread messages</span>
                  </span>
                </a>
              </li>
            </ul>
          </div>
        </div>
      </nav>
    </div>
  );
}

export default Navbar;
