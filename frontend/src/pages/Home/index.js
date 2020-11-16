import React, { useState, useEffect } from "react";
import { Link } from "react-router-dom";
import "../../styles/Home.css";
import moviesTitles from "../../data/movies.json";

import Banner from "../../components/Banner";
import Selection from "../../components/Selection";
import Card from "../../components/Card";

export default function Home() {
  const [totalMovies] = useState(8);
  const [total, setTotal] = useState(0);
  const [movies, setMovies] = useState([]);
  const [selectedMovies, setSelectedMovies] = useState([]);
  const [enableGenerateButton, setEnableGenerateButton] = useState(false);

  const handleCheckboxChange = (event, item) => {
    const isChecked = event.target.checked;

    if (isChecked) {
      setSelectedMovies([...selectedMovies, item]);
      setTotal(total + 1);
    } else {
      const titleIndex = selectedMovies.indexOf(item);
      selectedMovies.splice(titleIndex, 1);

      setTotal(total - 1);
    }
  };

  const enableButton = () => {
    if (total === totalMovies)
      setEnableGenerateButton(true);
    else
      setEnableGenerateButton(false);
  }

  const getMovies = async () => {
    const url = "http://copafilmes.azurewebsites.net/api/filmes";
    fetch(url, { mode: 'cors' }).then(r => console.log(r.data));
  }

  useEffect(() => {
    getMovies();
    setMovies(moviesTitles);
    enableButton();
  }, [total]);

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
        {enableGenerateButton &&
          <Link to={{ pathname: "/result", state: selectedMovies }}>
            Gerar Meu Campeonato
          </Link>
        }
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
