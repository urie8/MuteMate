import React from "react";
import "../Styles/spinner.css";
import angryMonkey from "../images/angryMonkey.png";


function Spinner() {
  return (
    <>
      <div className="spinner-wrapper">
        <div className="spinner-container">
          <div className="spinner"></div>
          <img
            src={angryMonkey}
            alt="Center"
            className="spinner-monkey-img"
          />
        </div>
      </div> 

      
    </>
  );
}

export default Spinner;
