import { ActionCreator, Dispatch } from "redux";
import { ThunkAction } from "redux-thunk";
import axios from "axios";

import { ICatalogItem, ICatalogItemState } from "../catalog/types";

export enum CatalogItemActionTypes {
  GET_ALL = "GET_ALL",
  GET_DETAIL = "GET_DETAIL",
  RESET_DETAIL = "RESET_DETAIL"
}

export interface ICatalogItemGetAllAction {
  type: CatalogItemActionTypes.GET_ALL;
  catalogItems: ICatalogItem[];
}

export interface ICatalogItemGetDetailAction {
  type: CatalogItemActionTypes.GET_DETAIL;
  activeCatalogItem: ICatalogItem;
}

export interface ICatalogItemResetDetailAction {
  type: CatalogItemActionTypes.RESET_DETAIL;
}

export type CatalogItemActions =
  | ICatalogItemGetAllAction
  | ICatalogItemGetDetailAction
  | ICatalogItemResetDetailAction;

// Get All Action
export const getAllCatalogItems: ActionCreator<
  ThunkAction<Promise<any>, ICatalogItemState, null, ICatalogItemGetAllAction>
> = () => {
  return async (dispatch: Dispatch) => {
    try {
      const response = await axios.get("http://localhost/api/catalog/");
      dispatch({
        catalogItems: response.data,
        loading: false,
        type: CatalogItemActionTypes.GET_ALL
      });
    } catch (err) {
      console.error(err);
    }
  };
};

// Get Detail Action
export const getDetailCatalogItem: ActionCreator<
  ThunkAction<
    Promise<any>,
    ICatalogItemState,
    null,
    ICatalogItemGetDetailAction
  >
> = code => {
  return async (dispatch: Dispatch) => {
    try {
      const response = await axios.get(`http://localhost/api/catalog/${code}`);
      dispatch({
        activeCatalogItem: response.data,
        loading: false,
        type: CatalogItemActionTypes.GET_DETAIL
      });
    } catch (err) {
      console.error(err);
    }
  };
};

export const resetDetailCatalogItem = () => {
  return {
    type: CatalogItemActionTypes.RESET_DETAIL
  };
};
