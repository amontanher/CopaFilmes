import React, { useState, useEffect } from 'react';
import './App.css';
import moviesTitles from './data/movies.json';

function App() {
  const [movies, setMovies] = useState([]);

  useEffect(()=>{
    setMovies(moviesTitles);
  },[])

  return (
    <ul>
      {movies.map(item => (
        <li key={item.id}>
          {item.titulo}
        </li>
      ))}
    </ul>
  );
}

export default App;
