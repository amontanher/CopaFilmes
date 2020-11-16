import React from 'react';
import '../styles/Banner.css';

export default function Banner({ title, description, project }) {
    return (
        <>
            <div className="box">
                <div>
                    <h4 id="h-pad">{project}</h4>
                    <h1 id="h-pad">{title}</h1>
                    <h5 id="h-pad">{description}</h5>
                </div>
            </div>
        </>
    );
}