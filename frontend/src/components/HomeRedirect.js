import React from 'react';
import { Link } from "react-router-dom";

import '../styles/Button.css';

export default function HomeRedirect() {
    return (
        <div className="notfound-container">
            <Link to="/">
                Clique aqui para iniciar um novo campeonato
            </Link>
        </div>
    );
}