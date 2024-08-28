import React, { useState, useEffect } from "react";
import "../Styles/home.css";
import { useNavigate } from "react-router-dom";

function home() {
  const navigate = useNavigate();
  const handleRegisterClick = () => {
    navigate("/register");};
    return (
      <>
        <div className="container">
          <div className="text-container">
            <div>
              <h1 className="title">
                Mute <br />
                Mate
              </h1>
            </div>
            <div>
              <h1 className="tagline">Say Less, Express More</h1>
            </div>
          </div>
          <div className="img-homepage"></div>
          <div className="button-container">
            <button className="button">Play</button>
            <button className="button" onClick={handleRegisterClick}>
              Sign up
            </button>
          </div>
          <h5 className="signIn-btn">Sign in</h5>
        </div>
      </>
    );
  };

export default home;
