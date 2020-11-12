import React from 'react';
import Banner from '../../components/Banner';
import Rank from '../../components/Rank';

export default function Result() {
    return (
        <div className="container">
            <Banner title="Resultado Final"
                project="CAMPEONATO DE FILMES"
                description="Veja o resultado final do Campeonato
                de Filmes de forma simples e rápida."/>
            <Rank position="1º" title="Campeão" />
            <Rank position="2º" title="Vice campeão" />
        </div>
    );
}