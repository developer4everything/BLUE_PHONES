import React from "react";
import { Link } from "react-router-dom";

const HomePage = () => {
  return (
    <div className="container">
      <Link style={{ color: "black" }} to={"catalog/"}>
        Catalog
      </Link>
    </div>
  );
};

export default HomePage;
