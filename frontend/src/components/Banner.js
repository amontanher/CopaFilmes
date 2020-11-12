import React from 'react';
import '../styles/Banner.css';

export default function Banner({ title, description, project }) {
    return (
        <>
            <div className="box">
                <div>
                    <h4>{project}</h4>
                    <h1>{title}</h1>
                    <h5>{description}</h5>
                </div>
            </div>
        </>
    );
}