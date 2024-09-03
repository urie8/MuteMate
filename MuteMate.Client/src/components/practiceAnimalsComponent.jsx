import React, { useState, useEffect } from "react";
import "../Styles/practiceAnimalsComponent.css";
import { ENDPOINTS } from "../api/apiEndpoints";
import pawprint from "../images/pawprint.png";

function practiceAnimalsComponent() {
  const [animalQuestions, setColorAnimals] = useState([]);

  useEffect(() => {
    fetch(ENDPOINTS.GETCATEGORIESANIMALS)
      .then((response) => response.json())
      .then((data) => setColorAnimals(data.$values))
      .catch((error) =>
        console.error("Error fetching color questions:", error)
      );
  }, []);

  return (
    <>
      <div className="practice-container">
        <div className="practice-colors-text-container">
          <div className="practice-animal-text">Practice: Animals</div>
          <img className="paw-image" src={pawprint} />
        </div>
      </div>

      <div className="search-container">
        <div className="search-bar-container"></div>
      </div>

      <div className="practice-animals-component-container">
        {animalQuestions.map((question) => {
          const imageUrl = `http://localhost:5237/${question.Image}`; // Full URL for the question image

          const correctAnswer = question.Answers.$values.find(
            (answer) => answer.IsCorrect
          );

          return (
            <div key={question.Id} className="practice-animals-card">
              <img
                className="practice-animals-tecken-image"
                src={imageUrl}
                alt="Tecken"
              />

              <div className="grey-line-practice-animals"></div>

              {correctAnswer && (
                <img
                  src={`http://localhost:5237/${correctAnswer.Answer}`}
                  alt="Correct Answer"
                  className="practice-animal-image"
                />
              )}
            </div>
          );
        })}
      </div>
    </>
  );
}

export default practiceAnimalsComponent;
