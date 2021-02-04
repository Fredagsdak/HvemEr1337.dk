import React from 'react';
import ReactDOM from 'react-dom';
import './index.css';
import Layout from './containers/layout/layout';
import { BrowserRouter } from 'react-router-dom';

ReactDOM.render(
  <React.StrictMode>
    <BrowserRouter>
      <Layout />
    </BrowserRouter>
  </React.StrictMode>,
  document.getElementById('root')
);