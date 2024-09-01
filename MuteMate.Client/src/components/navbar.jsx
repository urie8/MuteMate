import React from "react";
import { NavLink, useNavigate } from "react-router-dom";
import logo from "../images/MuteMateLogo.png";
import vines from "../images/vines.png";
import banan from "../images/banan1.png";
import vinesnoborder from "../images/vinenoborder.png";

import "../Styles/navbar.css";
import Hamburger from "hamburger-react";
import { useClickAway } from "react-use";
import { useRef } from "react";
import { useState, useEffect } from "react";
import { AnimatePresence, motion } from "framer-motion";

function Navbar() {
  const [isOpen, setOpen] = useState(false);
  const [isLoggedIn, setIsLoggedIn] = useState(false);
  const [user, setUser] = useState({ userName: "", password: "" });
  const navigate = useNavigate();

  const ref = useRef(null);

  // Close the menu when clicking outside of it
  useClickAway(ref, () => setOpen(false));

  useEffect(() => {
    const lsUserId = localStorage.getItem("isLoggedIn");
    const ssIsLoggedIn = sessionStorage.getItem("isLoggedIn");
    if (lsUserId || ssIsLoggedIn) {
      setIsLoggedIn(true);

      console.log("is logged in ", true);
    } else {
      setIsLoggedIn(false);
      console.log("is logged in ", false);
    }
    //lite osäker på om dependency arrayn ska ha dessa
  }, [
    // isLoggedIn,
    // localStorage.getItem("isLoggedIn"),
    // sessionStorage.getItem("isLoggedIn"),
  ]);

const handleLogOut = () => {
 setIsLoggedIn(false);
 console.log("User logged out");
 setUser({ userName: "", password: "" });
 localStorage.clear();
 sessionStorage.clear();
 navigate("/");

}
  const logOut = () => {
   handleLogOut();
  };

  const hamburgerLogOut = () => {
    handleLogOut();
    setOpen(false);
  }

  return (
    <>
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
            {isLoggedIn ? (
              <NavLink className="navbar-text" to="/" onClick={logOut}>
                Log out
                <img src={banan} alt="Logo" className="navbar-banan" />
              </NavLink>
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
                {isLoggedIn ? (
                  <NavLink
                    to="/"
                    className="dropdown-link"
                    onClick={hamburgerLogOut}
                  >
                    Log out
                  </NavLink>
                ) : (
                  <NavLink
                    to="/login"
                    className="dropdown-link"
                    onClick={() => setOpen(false)}
                  >
                    Log in
                  </NavLink>
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
                {isLoggedIn && (
                  <NavLink
                    to="/myPage"
                    className="dropdown-link"
                    onClick={() => setOpen(false)}
                  >
                    Profile
                  </NavLink>
                )}
              </motion.div>
            )}
          </AnimatePresence>
        </div>
      </div>
    </>
  );
}

export default Navbar;
