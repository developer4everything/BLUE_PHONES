import * as React from "react";
import { useEffect } from "react";
import { connect } from "react-redux";
import { AnyAction } from "redux";
import { ThunkDispatch } from "redux-thunk";
import { Link } from "react-router-dom";
import { IAppState } from "../store/Store";
import { ICatalogItem } from "../catalog/types";
import {
  ICatalogItemGetAllAction,
  getAllCatalogItems
} from "../actions/CatalogItemActions";
//import Grid from "react-css-grid";

// const holderStyle = {
//   marginTop: '20px',
//   display: 'inline-grid'
// }

interface IProps {
  getCatalogItems: () => Promise<ICatalogItemGetAllAction>;
  catalogItems: ICatalogItem[];
  catalogItemsLoading: boolean;
}

const CatalogItemList: React.FunctionComponent<IProps> = ({
  getCatalogItems,
  catalogItems,
  catalogItemsLoading
}) => {
  useEffect(() => {
    // Simulates a long request server.
    setTimeout(() => {
      getCatalogItems();
    }, 3000);
  }, []);

  return (
    <div className="container">
      {catalogItemsLoading && <div>Loading...</div>}
      {catalogItems &&
        catalogItems.map(catalogItem => {
          return (
            <div key={catalogItem.code}>
              <span className="name">{catalogItem.name}</span>
              &nbsp;&nbsp;&nbsp;
              <Link
                style={{ color: "black" }}
                to={"/catalog/" + catalogItem.code}
              >
                More details
              </Link>
              <br />
            </div>
          );
        })}
    </div>
  );
};

const mapStateToProps = (store: IAppState) => {
  return {
    catalogItems: store.catalogItemState.catalogItems,
    catalogItemsLoading: store.catalogItemState.loading
  };
};

const mapDispatchToProps = (dispatch: ThunkDispatch<any, any, AnyAction>) => {
  return {
    getCatalogItems: () => dispatch(getAllCatalogItems())
  };
};

export default connect(
  mapStateToProps,
  mapDispatchToProps
)(CatalogItemList);
