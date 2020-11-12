import React, { useState, useEffect } from 'react';
import '../../styles/Home.css';
import moviesTitles from '../../data/movies.json'

import Banner from '../../components/Banner';
import Button from '../../components/Button';
import Selection from '../../components/Selection';
import Card from '../../components/Card';

export default function Home() {
    const [movies, setMovies] = useState([]);
    const [selectedMovies, setSelectedMovies] = useState([]);

    const handleGenerateChampionship = () => {
        console.log("chama a API!");
    }

    //https://codesandbox.io/s/react-hooks-usestate-xzvq5?file=/src/index.js:583-593

    const handleCheckboxChange = (event) => {
        setSelectedMovies({ ...selectedMovies, [event.target.name]: event.target.checked });
        console.log("cliquei cehkbox");
    }

    useEffect(() => {
        setMovies(moviesTitles);
    }, [])

    return (
        <div className="container">
            <div>
                <Banner title="Fase de Seleção"
                    project="CAMPEONATO DE FILMES"
                    description="Selecione 8 filmes que você
                deseja que entrem na competição e depois
                pressione o botão Gerar Meu Campeonato
                para prosseguir." />
            </div>
            <div className="container-events">
                <Selection selecteds="0" total="8" />
                <Button title="Gerar Meu Campeonato" handleFunction={handleGenerateChampionship} />
            </div>
            <div className="container-list">
                {movies.map(item => (
                    <Card key={item.id} title={item.titulo} year={item.ano} handleFunction={handleCheckboxChange} />
                ))}
            </div>
        </div>
    );
}