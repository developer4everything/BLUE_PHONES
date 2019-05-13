import * as React from "react";
import * as ReactDOM from "react-dom";
import { BrowserRouter } from "react-router-dom";
import { Provider } from "react-redux";
import { Store } from "redux";
import configureStore, { IAppState } from "./store/Store";
import "./index.css";
import App from "./App";

interface IProps {
  store: Store<IAppState>;
}

const Root: React.FunctionComponent<IProps> = props => {
  return (
    <Provider store={props.store}>
      <BrowserRouter>
        <App />
      </BrowserRouter>
    </Provider>
  );
};

const store = configureStore();

ReactDOM.render(<Root store={store} />, document.getElementById(
  "root"
) as HTMLElement);
