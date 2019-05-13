import { Reducer } from "redux";
import {
  CatalogItemActions,
  CatalogItemActionTypes
} from "../actions/CatalogItemActions";
import { ICatalogItemState } from "../catalog/types";

// Define the initial state.
const initialCatalogItemState: ICatalogItemState = {
  catalogItems: [],
  activeCatalogItem: null,
  loading: true
};

export const catalogItemReducer: Reducer<
  ICatalogItemState,
  CatalogItemActions
> = (state = initialCatalogItemState, action) => {
  switch (action.type) {
    case CatalogItemActionTypes.GET_ALL: {
      return {
        ...state,
        catalogItems: action.catalogItems,
        loading: false
      };
    }
    case CatalogItemActionTypes.GET_DETAIL: {
      return {
        ...state,
        activeCatalogItem: action.activeCatalogItem,
        loading: false
      };
    }
    case CatalogItemActionTypes.RESET_DETAIL: {
      return {
        ...state,
        activeCatalogItem: null,
        loading: false
      };
    }
    default:
      return state;
  }
};
