import React, { useState, useEffect } from "react";
import "../Styles/home.css";
import { useNavigate } from "react-router-dom";

function home() {
  const navigate = useNavigate();
  const handleRegisterClick = () => {
    navigate("/register");};
    return (
      <>
      <div className="containerboxhome">
      <div className="container-home">
          <div className="text-container-home">
            {/* <div>
              <h1 className="title-home">
                Mute <br />
                Mate
              </h1>
            </div> */}
            <div>
              <h1 className="tagline-home">Say Less, Express More</h1>
            </div>
          </div>
          <div className="img-homepage"></div>
          <div className="button-containerhome">
            <button className="button">Play</button>
            <button className="button" onClick={handleRegisterClick}>
              Sign up
            </button>
          </div>
          <h5 className="signIn-btn">Sign in</h5>
        </div>
      </div>
        
      </>
    );
  };
export default home;
