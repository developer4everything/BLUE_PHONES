import * as React from "react";
import { useEffect } from "react";
import { connect } from "react-redux";
import { AnyAction } from "redux";
import { ThunkDispatch } from "redux-thunk";
import { Link } from "react-router-dom";
import { IAppState } from "../store/Store";
import { ICatalogItem } from "../catalog/types";
import {
  ICatalogItemGetDetailAction,
  getDetailCatalogItem,
  resetDetailCatalogItem,
  ICatalogItemResetDetailAction
} from "../actions/CatalogItemActions";
//import Grid from "react-css-grid";

interface IProps {
  getDetailItem: (code: number) => Promise<ICatalogItemGetDetailAction>;
  resetDetailItem: () => Promise<ICatalogItemResetDetailAction>;
  activeCatalogItem: ICatalogItem;
  catalogItemsLoading: boolean;
  code: number;
}

const CatalogItemDetail: React.FunctionComponent<IProps> = ({
  getDetailItem,
  resetDetailItem,
  activeCatalogItem,
  catalogItemsLoading,
  code
}) => {
  useEffect(() => {
    // Simulates a long request server.
    setTimeout(() => {
      getDetailItem(code);
    }, 3000);

    return () => {
      resetDetailItem();
    };
  }, [code]);

  if (activeCatalogItem === null) {
    return null;
  }

  return (
    <div className="container">
      <div key={activeCatalogItem.code}>
        <img
          src={process.env.PUBLIC_URL + activeCatalogItem.imageUrl}
          title={activeCatalogItem.name}
          alt={activeCatalogItem.name}
        />
        <br />
        <span className="name">{activeCatalogItem.code}</span>
        <br />
        <span className="name">{activeCatalogItem.name}</span>
        <br />
        <br />
        <span className="name">{activeCatalogItem.price}</span>
        <br />
        <span className="name">{activeCatalogItem.description}</span>
        <br />
        <span className="name">{activeCatalogItem.brand}</span>
        <br />
      </div>
      <Link style={{ color: "black" }} to={"/catalog"}>
        Return to Catalog List...
      </Link>
    </div>
  );
};

const mapStateToProps = (store: IAppState, props: any) => {
  return {
    activeCatalogItem: store.catalogItemState.activeCatalogItem,
    code: props.code
  };
};

const mapDispatchToProps = (
  dispatch: ThunkDispatch<any, any, AnyAction>,
  props: any
) => {
  return {
    getDetailItem: (code: number) => dispatch(getDetailCatalogItem(props.code)),
    resetDetailItem: () => {
      dispatch(resetDetailCatalogItem());
    }
  };
};

export default connect(
  mapStateToProps,
  mapDispatchToProps
)(CatalogItemDetail);
