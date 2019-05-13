import React from "react";
import { RouteComponentProps } from "react-router";
import CatalogItemDetail from "../components/CatalogItemDetail";

type TParams = { code: string };

const CatalogItemListPage = ({ match }: RouteComponentProps<TParams>) => {
  return (
    <div className="container">
      <h1>Catalog Item Detail</h1>
      <CatalogItemDetail code={match.params.code} />
    </div>
  );
};

export default CatalogItemListPage;
