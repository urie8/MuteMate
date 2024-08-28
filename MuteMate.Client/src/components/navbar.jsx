import React from "react";
import { NavLink } from "react-router-dom";
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

  const ref = useRef(null);

  // Close the menu when clicking outside of it
  useClickAway(ref, () => setOpen(false));

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
            <NavLink className="navbar-text" to="/login">
              Log in
              <img src={banan} alt="Logo" className="navbar-banan" />
            </NavLink>

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
                <NavLink
                  to="/login"
                  className="dropdown-link"
                  onClick={() => setOpen(false)}
                >
                  Register
                </NavLink>
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
                <NavLink
                  to="/myPage"
                  className="dropdown-link"
                  onClick={() => setOpen(false)}
                >
                  Profile
                </NavLink>

                {/* TODO: profile ska bara synas om man är inloggad */}
              </motion.div>
            )}
          </AnimatePresence>
        </div>
      </div>
    </>
  );
}

export default Navbar;
