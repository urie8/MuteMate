import React, { useState, useEffect } from "react";
import "../Styles/home.css";
import { ENDPOINTS } from "../api/apiEndpoints";
import { useNavigate } from "react-router-dom";

function home() {
  const navigate = useNavigate();
  const [userName, setuserName] = useState("");
  const [isLoggedIn, setIsLoggedIn] = useState(false);

  const checkLoginStatus = async () => {
    try {
      const response = await fetch(ENDPOINTS.IsAuthenticated, {
        method: "GET",
        credentials: "include",
      });
      const data = await response.json();
      console.log(data);
      setIsLoggedIn(data.isLoggedIn);
    } catch (error) {
      console.error("Error checking login status:", error);
    }
  };

  const GetLoggedInUserName = async () => {
    try {
      const response = await fetch(ENDPOINTS.GETLOGGEDINUSERNAME, {
        method: "GET",
        credentials: "include",
      });
      const data = await response.json();
      setuserName(data.username);
      console.log(data);
    } catch (error) {
      console.error("Error getting logged in username:", error);
    }
  };

  useEffect(() => {
    checkLoginStatus();
    GetLoggedInUserName();
  }, []);

  const handleRegisterClick = () => {
    navigate("/categoryOrPractice");
  };

  return (
    <>
      <div className="containerboxhome">
        <div className="container-home">
          <div className="text-container-home">
            <h1 className="tagline-home">Say Less, Express More</h1>
          </div>
          {isLoggedIn ? (
            <div className="landingpage-profileName">
              Good to see you {userName}!
            </div>
          ) : (
            <div className="landingpage-profileName">
              Hello Mute Mate! Are you ready to play?{" "}
            </div>
          )}
          <div className="img-homepage"></div>
          <div className="button-containerhome">
            <button className="button" onClick={handleRegisterClick}>
              Get Started
            </button>
          </div>
        </div>
      </div>
    </>
  );
}
export default home;
