import React from "react";
import "../styles/Card.css";

export default function Card({
  item,
  id,
  title,
  year,
  handleFunction,
  isChecked,
}) {
  return (
    <>
      <div className="container-card">
        <div className="container-check">
          <input
            type="checkbox"
            checked={isChecked}
            onChange={(e) => handleFunction(e, item)}
            value={id}
          />
        </div>
        <div className="container-detail">
          <h5>{title}</h5>
          <h6>{year}</h6>
        </div>
      </div>
    </>
  );
}
