import React, { useState, useEffect } from "react";
import "../../styles/Home.css";
import moviesTitles from "../../data/movies.json";

import Banner from "../../components/Banner";
import Button from "../../components/Button";
import Selection from "../../components/Selection";
import Card from "../../components/Card";

export default function Home() {
  const [total, setTotal] = useState(0);
  const [movies, setMovies] = useState([]);
  const [totalMovies] = useState(8);
  const [selectedMovies, setSelectedMovies] = useState([]);
  const [enableGenerateButton, setEnableGenerateButton] = useState(false);

  const handleGenerateChampionship = () => {
    console.log(selectedMovies);
  };

  const handleCheckboxChange = (event, item) => {
    const isChecked = event.target.checked;

    if (isChecked) {
      setSelectedMovies([...selectedMovies, item]);
      setTotal(total => total + 1);
    } else {
      const titleIndex = selectedMovies.indexOf(item);
      selectedMovies.splice(titleIndex, 1);

      setTotal(total => total - 1);
    }

    enableButton();
  };

  const enableButton = () => {
    if (total === 8)
      setEnableGenerateButton(true);
    else
      setEnableGenerateButton(false);
  }

  useEffect(() => {
    setMovies(moviesTitles);
  }, []);

  return (
    <div className="container">

      <div>
        <Banner
          title="Fase de Seleção"
          project="CAMPEONATO DE FILMES"
          description="Selecione 8 filmes que você
                deseja que entrem na competição e depois
                pressione o botão Gerar Meu Campeonato
                para prosseguir."
        />
      </div>

      <div className="container-events">
        <Selection selecteds={total} total={totalMovies} />
        {enableGenerateButton && <Button
          title="Gerar Meu Campeonato"
          handleFunction={handleGenerateChampionship}
        />}
      </div>

      <div className="container-list">
        {movies.map((item) => (
          <Card
            key={item.id}
            id={item.id}
            title={item.titulo}
            year={item.ano}
            item={item}
            totalSelected={total}
            totalMovies={totalMovies}
            handleFunction={handleCheckboxChange}
          />
        ))}
      </div>
    </div>
  );
}
