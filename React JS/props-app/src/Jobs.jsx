import React from "react";

function Jobs(props) {
  return (
    <div>
      <h1>{props.meslek}</h1>
      <h1>{props.dal}</h1>
      <h1>{props.okul}</h1>
      <h1>{props.alan}</h1>
    </div>
  );
}

export default Jobs;
