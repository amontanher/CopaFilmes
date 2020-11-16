import React from 'react';
import '../styles/Rank.css';

export default function Rank({ position, title }) {
    return (
        <>
            <div className="container-rank">
                <p id="position">{position}º</p>
                <p id="title">{title}</p>
            </div>
        </>
    );
}