import React from 'react';
import '../styles/Rank.css';

export default function Rank({ position, title }) {
    return (
        <>
            <div class="container-rank">
                <p id="position">{position}</p>
                <p id="title">{title}</p>
            </div>
        </>
    );
}