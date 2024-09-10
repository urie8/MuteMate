import React from "react";
import "../Styles/categoryOrPractice.css";
import { NavLink } from "react-router-dom";
import practice from "../images/practice.png";
import brain from "../images/brain.png";

function CategoryOrPractice() {
  return (
    <>
      <div className="category-practice-container">
        <div className="img-container">
          <NavLink to="/categoryQuiz" className="nav-link">
            <div className="img-inner">
              <div className="img-front">
                <div className="category-or-practice-text">Quiz</div>
              </div>
              <div className="img-back">
                <img className="pic-img" src={brain} alt="Quiz icon" />
              </div>
            </div>
          </NavLink>
        </div>
        <div className="img-container">
          <NavLink to="/categoryPractise" className="nav-link">
            <div className="img-inner">
              <div className="img-front">
                <div className="category-or-practice-text">Practice</div>
              </div>
              <div className="img-back">
                <img className="pic-img" src={practice} alt="Practice icon" />
              </div>
            </div>
          </NavLink>
        </div>

      </div>
    </>
  );
}

export default CategoryOrPractice;

