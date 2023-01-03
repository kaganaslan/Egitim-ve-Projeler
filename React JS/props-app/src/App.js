import "./App.css";
import Jobs from "./Jobs";
import Welcome from "./Welcome";
import datas from "./data";
import Meslek from "./Meslek";

function App() {
  const veri = datas;

  const name = "Kağan Aslan";
  const job = "Software Developer";
  const age = 25;
  const homeland = "T-rabzon";
  const img =
    "https://media.licdn.com/dms/image/C5603AQG3sCUsx3hQpQ/profile-displayphoto-shrink_800_800/0/1632734140809?e=2147483647&v=beta&t=ah1d2pxHdtsBDlIeICv-B02ABmAgogMPteBTIhZ2YPg";
  const school = "Medipol";

  return (
    <div className="App">
      {/* <Welcome
        meslek={job}
        ad={name}
        foto={img}
        okul={school}
        yas={age}
        memleket={homeland}
      /> */}
      {/* <Jobs
        meslek={veri.meslek}
        dal={veri.dal}
        okul={veri.universite}
        alan={veri.alan}
      /> */}
      <Meslek muzaffer={veri} />
    </div>
  );
}

export default App;
