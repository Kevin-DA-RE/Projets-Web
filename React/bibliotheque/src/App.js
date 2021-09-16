import React from 'react';
import { BrowserRouter as Router, Route } from 'react-router-dom';
import './App.css';
import Header from "./header/header";
import Films from './pages/films.js';
import Musiques from './pages/musique.js';
// import TableFilms from './pages/tableFilm.js';

function App() {
  return (
    <div className="App">
      <h1>Bienvenue au Greta</h1>
      <Router>
        <Header />
        <Route path="/" exact>
          <Films />
        </Route>
        <Route path="/musiques" exact>
          <Musiques />
        </Route>
        <Route path='/musique/new' exact>
        </Route>
      </Router>

    </div>
  );
}

export default App;
