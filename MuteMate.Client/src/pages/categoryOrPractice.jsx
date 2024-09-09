import React from "react";
import "../Styles/categoryOrPractice.css";
import { NavLink } from "react-router-dom";


function CategoryOrPractice() {
  return (
    <>
      <div className="category-practice-container">
        <NavLink to="/categoryQuiz" className="nav-link">
          <div className="category-or-practice-cards">
            <div className="category-or-practice-text">Quiz</div>
          </div>
        </NavLink>

        <NavLink to="/categoryPractise" className="nav-link">
          <div className="category-or-practice-cards">
            <div className="category-or-practice-text">Practice</div>
          </div>
        </NavLink>
      </div>
    </>
  );
}

export default CategoryOrPractice;
