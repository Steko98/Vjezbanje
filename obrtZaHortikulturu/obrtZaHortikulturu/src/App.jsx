import Navbar from './components/Navbar';

function App() {
  return (
    <div>
      <Navbar />

      <div className="container mt-5">
        <h1 className="text-center">Welcome to My Site</h1>
        <p className="text-center text-muted">This is a blank page with a Bootstrap navbar.</p>
      </div>
    </div>
  );
}

export default App;
