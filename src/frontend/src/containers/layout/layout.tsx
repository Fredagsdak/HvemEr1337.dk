import React from "react";
import TapAppBar from '../top-app-bar/top-app-bar';
import { Main } from './../main/main';
import { PageNotFound404 } from './../page-not-found-404/page-not-found-404';
import { Route, Switch } from "react-router-dom";

function Layout(): JSX.Element {
    return (
        <>
            <TapAppBar />
            <Switch>
                <Route exact path="/" component={Main} />
                <Route path="*" component={PageNotFound404} />
            </Switch>
        </>
    );
}

export default Layout;