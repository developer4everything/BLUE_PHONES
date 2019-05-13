import * as React from "react";
import { Route, BrowserRouter as Router, Switch } from "react-router-dom";
import HomePage from "./pages/HomePage";
import CatalogItemListPage from "./pages/CatalogItemListPage";
import CatalogItemDetailPage from "./pages/CatalogItemDetailPage";
import "./App.css";

const App: React.FunctionComponent<{}> = () => {
  return (
    <Router>
      <div>
        <Switch>
          <Route exact path="/" component={HomePage} />
          <Route exact path="/catalog" component={CatalogItemListPage} />
          <Route
            exact
            path="/catalog/:code"
            component={CatalogItemDetailPage}
          />
        </Switch>
      </div>
    </Router>
  );
};

export default App;
