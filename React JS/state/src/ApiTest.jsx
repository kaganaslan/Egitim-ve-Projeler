import axios from "axios";
import React, { useEffect, useState } from "react";

function ApiTest() {
  const URL = "https://jsonplaceholder.typicode.com/users";

  const [users, setUsers] = useState([]);
  const [singleUser, setSingleUser] = useState([]);

  useEffect(() => {
    axios
      .get(URL)
      .then((res) => setUsers(res.data))
      .catch((err) => console.log(err));
  }, []);

  console.log("Kullanıcı listesi", users);

  //   useEffect(() => {}, [])

  const onChangeHandler = (e) => {
    const id = e.target.value;
    // console.log("id numarası", id);

    axios.get(`${URL}/${id}`).then((res) => setSingleUser(res.data));
  };

  return (
    <div>
      <div className="container ">
        <h2 className="display-5 text-center">Kullanıcı Listesi</h2>
        <select
          name=""
          id=""
          className="form-select w-50 m-auto my-3 bg-warning"
          onChange={onChangeHandler}
        >
          <option disabled value="">
            Kullanıcı Seçiniz
          </option>
          <option disabled value="">
            XYZ
          </option>
          {users.map((user) => (
            <option key={user.id} value={user.id}>
              {user.name}
            </option>
          ))}
        </select>
      </div>

      <table className="table table-dark w-100 table-striped table-hover">
        <thead>
          <tr>
            <td>ID</td>
            <td>Name</td>
            <td>Username</td>
            <td>Email</td>
          </tr>
        </thead>
        <tbody>
          <tr>
            <td>{singleUser.id}</td>
            <td>{singleUser.name}</td>
            <td>{singleUser.username}</td>
            <td>{singleUser.email}</td>
          </tr>
        </tbody>
      </table>
    </div>
  );
}

export default ApiTest;
