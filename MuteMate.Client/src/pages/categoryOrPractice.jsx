import React from "react";
import "../Styles/categoryOrPractice.css";
import { NavLink } from "react-router-dom";
import quizPlanka from "../images/quizplanka.png";
import practicePlanka from "../images/practiceplanka.png";
import vines from "../images/vines.png";
import vinesinverted from "../images/vinesinverted.png";

function CategoryOrPractice() {
  return (
    <>
      <div className="category-practice-container">
        <div className="category-or-practice-cards">
          <div className="vines-container">
            <img
              src={vines}
              alt="Logo"
              className="vines-category-or-practice"
            />
            <img
              src={vinesinverted}
              alt="Logo"
              className="vines-category-or-practice"
            />
          </div>
          {/* <img
              src={vines}
              alt="Logo"
              className="vines-category-or-practice"
            />
          </div> */}
          <NavLink to="/categoryQuiz">
            {/* <div className="category-or-practice-text">Category</div> */}
            <img src={quizPlanka} alt="Logo" className="planka" />
          </NavLink>
        </div>
        <div className="category-or-practice-cards">
          <div className="vines-containers">
            <img
              src={vines}
              alt="Logo"
              className="vines-category-or-practice"
            />
            <img
              src={vinesinverted}
              alt="Logo"
              className="vines-category-or-practice"
            />
          </div>
          <NavLink to="/categoryPractise">
            <img src={practicePlanka} alt="Logo" className="planka planka-mindre" />
          </NavLink>
        </div>
      </div>
    </>
  );
}

export default CategoryOrPractice;
