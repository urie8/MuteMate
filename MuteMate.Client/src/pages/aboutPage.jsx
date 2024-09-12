import React, { Component } from "react";
import "../Styles/aboutPage.css";
import pawprint from "../images/pawprint.png";
import colorpic from "../images/chromatic.png";
import monkey from "../images/Monkeybubble.png";

import abc2 from "../images/abc2.png";
import { NavLink } from "react-router-dom";

function AboutPage() {
  return (
    <>
      <div className="about-container">
        <div className="about-text-container">
          <div className="about-title">About</div>
          <div className="about-information-text">
            <div className="intro-text">
              Welcome to our website! Here, kids can have fun while learning and
              practicing sign language through interactive quizzes.
            </div>

            <div className="different-offers-text">
              We offer different types of sign language quizzes where kids can
              practice and test their knowledge on:
            </div>

            <div className="about-category-containers">
              <NavLink to="/quiz/animals" className="about-text-links">
                <div className="animals-letters-colors-text">
                  Animals
                  <img
                    className="about-paw-image"
                    src={pawprint}
                    alt="Pawprint"
                  />
                </div>
              </NavLink>
              <NavLink to="/quiz/letters" className="about-text-links">
                <div className="animals-letters-colors-text">
                  Letters{" "}
                  <img className="about-abc-image" src={abc2} alt="ABC" />
                </div>
              </NavLink>

              <NavLink to="/quiz/colors" className="about-text-links">
                <div className="animals-letters-colors-text">
                  Colors
                  <img
                    className="about-color-image"
                    src={colorpic}
                    alt="Pawprint"
                  />
                </div>
                {/* <img className="about-monkey-image" src={monkey} alt="ABC" /> */}
              </NavLink>
            </div>

            <div className="ending-text">
              These quizzes are designed to make learning fun and help kids
              build their confidence in using sign language. Let’s start
              learning and explore the world of sign language together!
            </div>
          </div>
        </div>
      </div>
    </>
  );
}
export default AboutPage;
