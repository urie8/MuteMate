import React, { useState, useEffect } from "react";
import "../Styles/practiceAnimalsComponent.css";
import { ENDPOINTS } from "../api/apiEndpoints";
import pawprint from "../images/pawprint.png";
import SearchBar from "./searchBarComponent"; 
import SearchBarMobile from "./searchbarMobile";

function PracticeAnimalsComponent() {
  const [animalQuestions, setAnimalQuestions] = useState([]);
  const [searchQuery, setSearchQuery] = useState("");

  useEffect(() => {
    fetch(ENDPOINTS.GETCATEGORIESANIMALS)
      .then((response) => response.json())
      .then((data) => setAnimalQuestions(data.$values))
      .catch((error) =>
        console.error("Error fetching animal questions:", error)
      );
  }, []);

  // Filtrerar animals questions
  const filteredQuestions = animalQuestions.filter((question) => {
    const correctAnswer = question.Answers?.$values?.find(
      (answer) => answer.IsCorrect
    );

    const questionTitle = question.Title?.toLowerCase() || "";
    const correctAnswerText = correctAnswer?.Answer?.toLowerCase() || "";

    return (
      questionTitle.includes(searchQuery.toLowerCase()) ||
      correctAnswerText.includes(searchQuery.toLowerCase())
    );
  });

  return (
    <>
      <div className="practice-container">
        <div className="practice-colors-text-container">
          <div className="practice-animal-text">Practice: Animals</div>
          <img className="paw-image" src={pawprint} alt="Pawprint" />

          <SearchBar
            searchQuery={searchQuery}
            setSearchQuery={setSearchQuery}
          />
        </div>
      </div>

      <SearchBarMobile
        searchQuery={searchQuery}
        setSearchQuery={setSearchQuery}
      />

      <div className="practice-animals-component-container">
        {filteredQuestions.map((question) => {
          const imageUrl = `http://localhost:5237/${question.Image}`; // Full URL for the question image

          const correctAnswer = question.Answers?.$values?.find(
            (answer) => answer.IsCorrect
          );

          return (
            <div key={question.Id} className="practice-animals-card">
              <img
                className="practice-animals-tecken-image"
                src={imageUrl}
                alt={question.Title || "Animal Image"}
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

export default PracticeAnimalsComponent;

