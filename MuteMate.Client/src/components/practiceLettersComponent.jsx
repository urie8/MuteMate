import React, { useState, useEffect } from "react";
import "../Styles/practiceLettersComponent.css";
import { ENDPOINTS } from "../api/apiEndpoints";
import abc2 from "../images/abc2.png";
import SearchBar from "./searchBarComponent";
import SearchBarMobile from "./searchbarMobile";

function PracticeLettersComponent() {
  const [lettersQuestions, setLettersQuestions] = useState([]);
  const [searchQuery, setSearchQuery] = useState("");

  useEffect(() => {
    fetch(ENDPOINTS.GETCATEGORIESLETTERS)
      .then((response) => response.json())
      .then((data) => setLettersQuestions(data.$values))
      .catch((error) =>
        console.error("Error fetching letter questions:", error)
      );
  }, []);

  // Filtrerar lettersQuestions baserat på vad användaren har skrivit
  const filteredQuestions = lettersQuestions.filter((question) => {
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
          <div className="practice-animal-text">Practice: Letters</div>
          <img className="abc-image" src={abc2} alt="ABC" />
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

      <div className="practice-letters-component-container">
        {filteredQuestions.map((question) => {
          const imageUrl = `http://localhost:5237/${question.Image}`; // Full URL for the question image

          const correctAnswer = question.Answers?.$values?.find(
            (answer) => answer.IsCorrect
          );

          return (
            <div key={question.Id} className="practice-letters-card">
              <img
                className="practice-letters-tecken-image"
                src={imageUrl}
                alt="Tecken"
              />

              <div className="grey-line-practice-letters"></div>

              {correctAnswer && (
                <p className="practice-letter-correct-answer">
                  {correctAnswer.Answer}
                </p>
              )}
            </div>
          );
        })}
      </div>
    </>
  );
}

export default PracticeLettersComponent;
