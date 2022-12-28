import './App.css';
import Employees from './components/Employees';
import Footer from './components/Footer';
import Navbar from './components/Navbar';
import Slider from './components/Slider';

function App() {
  return (
    <div className="App">
    <Navbar />
    <Slider />
    <Employees/>
    <Footer/>
    </div>
  );
}
export default App;
