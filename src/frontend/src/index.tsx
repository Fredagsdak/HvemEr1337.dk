import React from 'react';
import ReactDOM from 'react-dom';
import './index.css';
import Layout from './containers/layout/layout';
import { BrowserRouter } from 'react-router-dom';
import { Provider } from "react-redux";
import store from './store/store';

ReactDOM.render(
  <React.StrictMode>
    <Provider store={store}>
      <BrowserRouter>
        <Layout />
      </BrowserRouter>
    </Provider>
  </React.StrictMode>,
  document.getElementById('root')
);