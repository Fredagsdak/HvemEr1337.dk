import React from 'react';
import ReactDOM from 'react-dom';
import './index.css';
import Layout from './containers/layout/layout';
import { BrowserRouter } from 'react-router-dom';
import { createStore, applyMiddleware, Store } from "redux";
import { Provider } from "react-redux";
import thunk from "redux-thunk";
import reducer from "./store/reducer";

const store: Store<PostState, PostAction> & {
  dispatch: DispatchType
} = createStore(reducer, applyMiddleware(thunk));

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