import React from 'react';

import Banner from '../../components/Banner';
import HomeRedirect from '../../components/HomeRedirect';

export default function NotFound() {
    return (
        <div className="container">
            <Banner title="Oops..."
                project="CAMPEONATO DE FILMES"
                description="A página solicitada não foi encontrada." />
            <HomeRedirect />
        </div>
    );
}