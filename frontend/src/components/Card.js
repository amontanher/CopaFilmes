import React from 'react';
import '../styles/Card.css';

export default function Card({ title, year }) {
    return (
        <>
            <div className="container-card">
                <div className="container-check">
                    <p>Check</p>
                </div>
                <div className="container-detail">
                    <h5>{title}</h5>
                    <h6>{year}</h6>
                </div>
            </div>
        </>
    );
}