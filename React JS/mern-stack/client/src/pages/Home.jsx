import React from "react";
import { useEffect } from "react";
import axios from "axios";
import { useState } from "react";
import Swal from "sweetalert2";

function Home() {
  const [users, setUsers] = useState([]);

  const [name, setName] = useState("");
  const [age, setAge] = useState(0);
  const [username, setUsername] = useState("");
  const [img, setImg] = useState("");

  const [newName, setNewName] = useState("");

  useEffect(() => {
    axios
      .get("http://localhost:5000/getUsers")
      .then((res) => setUsers(res.data))
      .catch((err) => console.log(err));
  }, [users, name]);

  const createUser = () => {
    axios.post("http://localhost:5000/createUser", {
      name: name,
      age: age,
      username: username,
      img: img,
    });
    Swal.fire({
      title: "Yeni Kullanıcı Başarıyla Oluşturldu",
      width: 600,
      padding: "3em",
      color: "#716add",
      background: "#fff url(https://sweetalert2.github.io/images/trees.png)",
      backdrop: `
        rgba(0,0,123,0.4)
        url("https://sweetalert2.github.io/images/nyan-cat.gif")
        left top
        no-repeat
      `,
    });
  };

  const updateUser = (id) => {
    axios.put("http://localhost:5000/updateUser", {
      id: id,
      newName: newName,
    });
    Swal.fire({
      title: "Kullanıcı Güncelleme İşlemi Başarılı",
      width: 600,
      padding: "3em",
      color: "#716add",
      background: "#fff url(https://sweetalert2.github.io/images/trees.png)",
      backdrop: `
        rgba(0,0,123,0.4)
        url("https://sweetalert2.github.io/images/nyan-cat.gif")
        left top
        no-repeat
      `,
    });
  };

  const deleteUser = (id) => {
    axios.delete(`http://localhost:5000/deleteUser/${id}`);
    Swal.fire({
      title: "Kullanıcı Silme İşlemi Başarılı",
      width: 600,
      padding: "3em",
      color: "#716add",
      background: "#fff url(https://sweetalert2.github.io/images/trees.png)",
      backdrop: `
        rgba(0,0,123,0.4)
        url("https://sweetalert2.github.io/images/nyan-cat.gif")
        left top
        no-repeat
      `,
    });
  };

  return (
    <div>
      <h2 className="text-center text-danger">Yeni Kullanıcı Oluştur</h2>
      <table className="table table-dark">
        <thead>
          <tr>
            <th>Ad</th>
            <th>Yaş</th>
            <th>Kullanıcı Adı</th>
            <th>Fotoğraf Linki</th>
          </tr>
        </thead>
        <tbody>
          <tr>
            <td>
              <input
                type="text"
                id="name"
                className="form-control"
                placeholder="Adınızı Giriniz"
                onChange={(e) => setName(e.target.value)}
              />
            </td>
            <td>
              <input
                type="text"
                id="yas"
                className="form-control"
                placeholder="Yaşınızı Giriniz"
                onChange={(e) => setAge(e.target.value)}
              />
            </td>
            <td>
              <input
                type="text"
                id="username"
                className="form-control"
                placeholder="Kullanıcı Adınızı Giriniz"
                onChange={(e) => setUsername(e.target.value)}
              />
            </td>
            <td>
              <input
                type="text"
                id="img"
                className="form-control"
                placeholder="Fotoğrafınızı Giriniz"
                onChange={(e) => setImg(e.target.value)}
              />
            </td>
          </tr>
          <tr>
            <td colSpan={4}>
              <button className="btn btn-warning w-25" onClick={createUser}>
                Kaydet
              </button>
            </td>
          </tr>
        </tbody>
      </table>
      <h1 className="display-4 text-danger">ÇALIŞANLAR LİSTESİ</h1>
      <div className="row my-3">
        {users.map((user) => (
          <div className="col-md-6 my-3">
            <div className="card m-auto" style={{ width: "18rem" }}>
              <img src={user.img} className="card-img-top" alt="..." />
              <div className="card-body">
                <h5 className="card-title">{user.name}</h5>
                <input
                  placeholder="Güncellenecek İsmi Giriniz"
                  className="form-control"
                  onChange={(e) => setNewName(e.target.value)}
                />
                <div className="row my-2">
                  <div className="col-md-6">
                    <button
                      className="btn btn-info w-100"
                      onClick={() => updateUser(user._id)}
                    >
                      Güncelle
                    </button>
                  </div>
                  <div className="col-md-6">
                    <button
                      className="btn btn-danger w-100"
                      onClick={() => deleteUser(user._id)}
                    >
                      Sil
                    </button>
                  </div>
                </div>

                <p className="card-text">Yaşı: {user.age}</p>
                <p className="card-text">Kullanıcı Adı: {user.username}</p>
                <a href="#" className="btn btn-primary">
                  Go somewhere
                </a>
              </div>
            </div>
          </div>
        ))}
      </div>
    </div>
  );
}

export default Home;
