import React from "react";
import "../Styles/categoryOrPractice.css";
import { NavLink } from "react-router-dom";

function CategoryOrPractice() {
  return (
    <>
      <div className="category-practice-container">
        <div className="category-or-practice-cards">
          <NavLink to="/categoryQuiz">
            <div className="category-or-practice-text">Category</div>
          </NavLink>
        </div>
        <div className="category-or-practice-cards">
          <NavLink to="/practise">
            <div className="category-or-practice-text">Practice</div>
          </NavLink>
        </div>
      </div>
    </>
  );
}

export default CategoryOrPractice;
