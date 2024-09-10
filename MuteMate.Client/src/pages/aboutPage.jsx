import React, { Component } from "react";
import "../Styles/aboutPage.css";

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
              <div className="animals-letters-colors-text">Animals</div>
              <div className="animals-letters-colors-text">Letters</div>
              <div className="animals-letters-colors-text">Colors</div>
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
