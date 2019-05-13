import { applyMiddleware, combineReducers, createStore, Store } from "redux";
import thunk from "redux-thunk";
import { catalogItemReducer } from "../reducers/catalogItemReducer";
import { ICatalogItemState } from "../catalog/types";

// Create an interface for the application state.
export interface IAppState {
  catalogItemState: ICatalogItemState;
}

// Create the root reducer.
const rootReducer = combineReducers<IAppState>({
  catalogItemState: catalogItemReducer
});

// Create a configure store function of type 'IAppState'.
export default function configureStore(): Store<IAppState, any> {
  const store = createStore(rootReducer, undefined, applyMiddleware(thunk));
  return store;
}
