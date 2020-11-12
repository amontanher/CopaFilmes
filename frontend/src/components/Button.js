import React from 'react';
import '../styles/Button.css';

export default function Button({ title, handleFunction }) {
    return (
        <>
            <div>
                <a href="#" onClick={handleFunction}>{title}</a>
            </div>
        </>
    );
}