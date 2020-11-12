import React from 'react';
import '../styles/Button.css';

export default function Button({ title, color }) {
    return (
        <>
            <div>
                <a href="#">{title}</a>
            </div>
        </>
    );
}