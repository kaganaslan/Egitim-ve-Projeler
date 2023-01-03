import React from "react";

function Meslek({ muzaffer }) {
  return (
    <div>
      <h1>{muzaffer.meslek}</h1>
      <h1>{muzaffer.dal}</h1>
      <h1>{muzaffer.universite}</h1>
      <h1>{muzaffer.alan}</h1>
    </div>
  );
}

export default Meslek;
