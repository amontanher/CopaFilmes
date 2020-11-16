import React, { useEffect, useState } from "react";
import { useLocation } from "react-router-dom";
import axios from "axios";

import Banner from "../../components/Banner";
import Rank from "../../components/Rank";
import HomeRedirect from "../../components/HomeRedirect";

export default function Result() {
  const location = useLocation();
  const [showResult, setShowResult] = useState(false);
  const [result, setResult] = useState([]);

  useEffect(() => {
    handleGenerateChampionship();
  });

  const handleGenerateChampionship = () => {
    var selectedMovies = location.state;
    if (selectedMovies) {
      axios
        .post("https://localhost:5001/api/championship", selectedMovies)
        .then((resp) => setResult(resp.data));
      setShowResult(true);
    }
  };

  return (
    <div className="container">
      <Banner
        title="Resultado Final"
        project="CAMPEONATO DE FILMES"
        description="Veja o resultado final do Campeonato
                de Filmes de forma simples e rápida."
      />

      {showResult && (
        <div>
          {result.map((r, index) => {
            return <Rank key={index} position={r.position} title={r.title} />;
          })}
        </div>
      )}

      <HomeRedirect />
    </div>
  );
}
