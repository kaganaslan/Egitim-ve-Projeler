const express = require("express");
const mongoose = require("mongoose");
const UserModel = require("./models/Users");
const cors = require("cors");

const app = express();
app.use(express.json());
app.use(cors());

mongoose.set("strictQuery", false);
mongoose.connect(
  "mongodb+srv://admin:1234@cluster0.hjmzrzs.mongodb.net/firstdb?retryWrites=true&w=majority"
);
//get metodunun endpointini hazırladık. artık localhost:5000/getUsers linkini kullanarak veritabanımızdaki verileri çekeceğiz.

//get motodu
app.get("/getUsers", (req, res) => {
  UserModel.find({}, (err, result) => {
    if (err) {
      res.json(err);
    } else {
      res.json(result);
    }
  });
});

//post metodu
app.post("/createUser", async (req, res) => {
  const user = req.body;
  const newUser = new UserModel(user);
  await newUser.save();

  res.json(user);
});

//put metodu

app.put("/updateUser", async (req, res) => {
  const newName = req.body.newName;
  const id = req.body.id;

  try {
    await UserModel.findById(id, (err, guncellenen) => {
      guncellenen.name = newName;
      guncellenen.save();
    });
  } catch (error) {
    console.log(error);
  }

  res.json("başarılı");
});

//delete metodu
app.delete("/deleteUser/:id", async (req, res) => {
  const id = req.params.id;
  await UserModel.findByIdAndRemove(id).exec();
  res.send("Silme Başarılı");
});

app.listen(5000, () => {
  console.log("Server is running 🔥 ");
});
