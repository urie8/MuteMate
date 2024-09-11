import React, { useEffect } from "react";
import { NavLink, useNavigate } from "react-router-dom";
import { ENDPOINTS } from "../api/apiEndpoints";
import logo from "../images/MuteMateLogo.png";
import vines from "../images/vines.png";
import banan from "../images/banan1.png";
import vinesnoborder from "../images/vinenoborder.png";

import "../Styles/navbar.css";
import Hamburger from "hamburger-react";
import { useClickAway } from "react-use";
import { useRef } from "react";
import { useState } from "react";
import { AnimatePresence, motion } from "framer-motion";

function Navbar() {
  const [isOpen, setOpen] = useState(false);
  const [isLoggedIn, setIsLoggedIn] = useState(false);
  const navigate = useNavigate();
  const ref = useRef(null);

  // Close the menu when clicking outside of it
  useClickAway(ref, () => setOpen(false));

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

  const handleLogout = () => {
    fetch(ENDPOINTS.LOGOUT, { method: "POST", credentials: "include" })
      .then((response) => response.json())
      .then((data) => {
        if (data.success) {
          setIsLoggedIn(false); // Update state to logged out
          window.location.href = "/";
        }
      })
      .catch((error) => console.error("Error logging out:", error));
  };

  useEffect(() => {
    checkLoginStatus();
    console.log(isLoggedIn);
  }, []);

  return (
    <>
      <div
        className={`navbar-overlay ${isOpen ? "active" : ""}`}
        onClick={() => setOpen(false)}
      ></div>
      <div className="container-navbar">
        <div className="navbar-wrapper" ref={ref}>
          <img src={vinesnoborder} alt="Logo" className="navbar-vine" />

          <div className="title-pic-wrapper">
            <NavLink to="/">
              <img src={logo} alt="Logo" className="navbar-logo" />
            </NavLink>
            <div className="mute-mate-text">MUTE MATE</div>
          </div>

          <div className="navbar-link-wrapper">
            <NavLink className="navbar-text" to="/categoryQuiz">
              Quiz
            </NavLink>
            <NavLink className="navbar-text" to="/categoryPractise">
              Practice
            </NavLink>
            <NavLink className="navbar-text" to="/about">
              About us
            </NavLink>

            {isLoggedIn ? (
              <>
                <NavLink className="navbar-text" to="/myPage">
                  Profile
                </NavLink>
                <NavLink
                  className="navbar-text"
                  to="/"
                  onClick={(e) => {
                    e.preventDefault();
                    handleLogout();
                  }}
                >
                  Log out
                </NavLink>
              </>
            ) : (
              <NavLink className="navbar-text" to="/login">
                Log in
                <img src={banan} alt="Logo" className="navbar-banan" />
              </NavLink>
            )}

            {/* <img src={banan} alt="Logo" className="navbar-banan" /> */}

            <img src={vinesnoborder} alt="Logo" className="navbar-vine" />
          </div>

          <Hamburger
            toggled={isOpen}
            toggle={setOpen}
            className="hamburger-react"
          />
          <AnimatePresence>
            {isOpen && (
              <motion.div
                className="dropdown-menu"
                initial={{ opacity: 0, y: -20 }}
                animate={{ opacity: 1, y: 0 }}
                exit={{ opacity: 0, y: -20 }}
              >
                {!isLoggedIn ? (
                  <>
                    <NavLink
                      to="/login"
                      className="dropdown-link"
                      onClick={() => setOpen(false)}
                    >
                      Register
                    </NavLink>
                    <NavLink
                      to="/login"
                      className="dropdown-link"
                      onClick={() => setOpen(false)}
                    >
                      Log in
                    </NavLink>
                  </>
                ) : (
                  <>
                    <NavLink
                      to="/myPage"
                      className="dropdown-link"
                      onClick={() => setOpen(false)}
                    >
                      Profile
                    </NavLink>
                    <NavLink
                      to="/"
                      className="dropdown-link"
                      onClick={(e) => {
                        e.preventDefault();
                        handleLogout();
                        setOpen(false); // Close the menu after logout
                      }}
                    >
                      Log out
                    </NavLink>
                  </>
                )}
                <NavLink
                  to="/categoryQuiz"
                  className="dropdown-link"
                  onClick={() => setOpen(false)}
                >
                  Quiz
                </NavLink>
                <NavLink
                  to="/categoryPractise"
                  className="dropdown-link"
                  onClick={() => setOpen(false)}
                >
                  Practice
                </NavLink>
                <NavLink
                  to="/about"
                  className="dropdown-link"
                  onClick={() => setOpen(false)}
                >
                  About
                </NavLink>
              </motion.div>
            )}
          </AnimatePresence>
        </div>
      </div>
    </>
  );
}

export default Navbar;


