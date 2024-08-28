import React, { useState, useEffect } from "react";
import "../Styles/myPage.css";
import banana from "../images/banan1.png";
import vines from "../images/vines.png";
import { useNavigate } from "react-router-dom";

//Import från API, användaruppgifter och poäng.

function myPage() {
  return (
    <>
      <div className="Container-profile">
        <h1 className="title-profile">
          PROFILE PAGE
          <div className="picture-container">
            <img src={vines} alt="vines" className="vines-1" />
            <img src={vines} alt="vines" className="vines-1" />
          </div>
        </h1>

        <div className="userNameContainer">
          <div className="display-userName">username </div>
          {/* Username ska hämtas här */}
        </div>
        <div className="banana-display">
          <img src={banana} alt="banan" className="banana1" />
          <div className="banana-point">Hämta bananer här från API</div>
          <div className="banana-text">Your collected bananas!</div>
        </div>
      </div>
    </>
  );
}

export default myPage;
