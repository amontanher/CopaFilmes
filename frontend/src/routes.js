import React from 'react';
import { Switch, Route } from 'react-router-dom';

import Home from './pages/Home';
import Result from './pages/Result';
import NotFound from './pages/NotFound';

const Routes = () => (
    <>
        <Switch>
            <Route exact path="/" component={Home}></Route>
            <Route exact path="/result" component={Result}></Route>
            <Route exact path="*" component={NotFound}></Route>
        </Switch>
    </>
)

export default Routes;