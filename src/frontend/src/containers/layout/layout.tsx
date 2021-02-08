import React from "react";
import TapAppBar from '../top-app-bar/top-app-bar';
import { Main } from './../main/main';
import { PageNotFound404 } from './../page-not-found-404/page-not-found-404';
import { Route, Switch } from "react-router-dom";
import { Routes } from './../../shared/routes';
import { Post1337 } from './../post1337/post1337';

function Layout(): JSX.Element {
    return (
        <>
            <TapAppBar />
            <Switch>
                <Route exact path={Routes.root} component={Main} />
                <Route exact path={Routes.be1337} component={Post1337} />
                <Route path="*" component={PageNotFound404} />
            </Switch>
        </>
    );
}

export default Layout;