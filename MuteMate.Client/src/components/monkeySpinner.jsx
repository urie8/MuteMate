import React from "react";
import "../Styles/spinner.css";
import angryMonkey from "../images/angryMonkey.png";
import banana from "../images/banana.png";

function MonkeySpinner() {
  return (
    <div className="spinner-container">
      <img src={angryMonkey} alt="Monkey" className="spinner-monkey-img" />
      <img className="spinner-banana-img banana-1" src={banana} alt="Banana" />
      <img className="spinner-banana-img banana-2" src={banana} alt="Banana" />
      <img className="spinner-banana-img banana-3" src={banana} alt="Banana" />
      <img className="spinner-banana-img banana-4" src={banana} alt="Banana" />
      <img className="spinner-banana-img banana-5" src={banana} alt="Banana" />
      <img className="spinner-banana-img banana-6" src={banana} alt="Banana" />
      <img className="spinner-banana-img banana-7" src={banana} alt="Banana" />
      <img className="spinner-banana-img banana-8" src={banana} alt="Banana" />
      <img className="spinner-banana-img banana-9" src={banana} alt="Banana" />
      <img className="spinner-banana-img banana-10" src={banana} alt="Banana" />
    </div>
  );
}

export default MonkeySpinner;
