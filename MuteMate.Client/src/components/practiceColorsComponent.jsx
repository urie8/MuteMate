import React, { useState, useEffect } from "react";
import "../Styles/practiceColorsComponent.css";
import { ENDPOINTS } from "../api/apiEndpoints";
import SearchBar from "./searchBarComponent";
import colorpic from "../images/chromatic.png";
import SearchBarMobile from "./searchbarMobile";

function PracticeColorsComponent() {
  const [colorQuestions, setColorQuestions] = useState([]);
  const [searchQuery, setSearchQuery] = useState("");

  useEffect(() => {
    fetch(ENDPOINTS.GETCATEGORIESCOLORS)
      .then((response) => response.json())
      .then((data) => setColorQuestions(data.$values))
      .catch((error) =>
        console.error("Error fetching color questions:", error)
      );
  }, []);

  //Funktion för att ge answers en klass med färg
  const getColorClass = (answer) => {
    switch (answer.toLowerCase()) {
      case "orange":
        return "orange-text common-style";
      case "blue":
        return "blue-text common-style";
      case "red":
        return "red-text common-style";
      case "green":
        return "green-text common-style";
      case "yellow":
        return "yellow-text common-style";
      case "purple":
        return "purple-text common-style";
      case "black":
        return "black-text common-style";
      case "grey":
        return "grey-text common-style";
      case "pink":
        return "pink-text common-style";
      case "white":
        return "white-text common-style";
      case "brown":
        return "brown-text common-style";
      default:
        return ""; // Default to no color class
    }
  };

  const filteredQuestions = colorQuestions.filter((question) => {
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
          <div className="practice-text">Practice: Colors</div>
          <img className="color-image" src={colorpic} alt="Pawprint" />
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

      <div className="practice-colors-component-container">
        {filteredQuestions.map((question) => {
          const imageUrl = `http://localhost:5237/${question.Image}`; // Full URL for the image

          const correctAnswer = question.Answers?.$values?.find(
            (answer) => answer.IsCorrect
          );
          const answerClass = getColorClass(correctAnswer?.Answer);

          return (
            <div key={question.Id} className="practice-colors-card">
              <img
                className="practice-colors-image"
                src={imageUrl}
                alt="Color"
              />

              <div className="grey-line-practice-colors"></div>

              <p className={answerClass}>{correctAnswer?.Answer}</p>
            </div>
          );
        })}
      </div>
    </>
  );
}

export default PracticeColorsComponent;
