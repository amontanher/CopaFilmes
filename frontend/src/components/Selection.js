import React from 'react';
import '../styles/Selection.css';

export default function Selection({ selecteds, total }) {
    return (
        <>
            <div className="select-container">
                <p>Selecionados</p>
                <h4>{selecteds} de {total} filmes</h4>
            </div>
        </>
    );
}