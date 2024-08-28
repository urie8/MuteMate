import React, { useState } from "react";
import { useNavigate } from "react-router-dom";
import "../categoryPractise.css";

function CategoryPractiseQuiz({ message, linkTo }) {
  const [category, setCategory] = useState([]);
  const navigate = useNavigate();

  function handleImageClick() {
    //Måste kolla vilken bild som klickats

    navigate("/practice");
  }
  return (
    <>
      <div className="page-wrapper">
        <h2 className="choose-text">{message}</h2>
        <div className="option-img-container">
          <div className="img-container">
            <img
              className="option-img"
              src="MiiaImages/color-wheel.png"
              onClick={() => handleImageClick("colors")}
            />
          </div>
          <div className="img-container">
            <img
              className="option-img"
              src="MiiaImages/abc.png"
              onClick={() => handleImageClick("letters")}
            />
          </div>
          <div className="img-container">
            <img
              className="option-img"
              src="MiiaImages/livestock.png"
              onClick={() => handleImageClick("animals")}
            />
          </div>
        </div>
      </div>
    </>
  );
}

export default CategoryPractiseQuiz;
