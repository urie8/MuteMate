


import React, { useState, useEffect } from "react";
import "../Styles/practiceColorsComponent.css";
import { ENDPOINTS } from "../api/apiEndpoints";

function PracticeColorsComponent() {
  const [colorQuestions, setColorQuestions] = useState([]);

  useEffect(() => {
    fetch(ENDPOINTS.GETCATEGORIESCOLORS)
      .then((response) => response.json())
      .then((data) => setColorQuestions(data.$values))
      .catch((error) =>
        console.error("Error fetching color questions:", error)
      );
  }, []);

  // Function to map answers to CSS classes
  const getColorClass = (answer) => {
    switch (answer.toLowerCase()) {
      case "orange":
        return "orange-text";
      case "blue":
        return "blue-text";
      case "red":
        return "red-text";
      case "green":
        return "green-text";
      case "yellow":
        return "yellow-text";
      case "purple":
        return "purple-text";
      case "black":
        return "black-text";
      case "grey":
        return "grey-text";
      case "pink":
        return "pink-text";
      case "white":
        return "white-text";
      default:
        return ""; // Default to no color class
    }
  };

  return (
    <>
          <div className="practice-container">
        <div className="practice-colors-text-container">
          <div className="practice-text">Practice:</div>
          <div className="colors-text-container">
            <div className="c-text">C</div>
            <div className="o-text">o</div>
            <div className="l-text">l</div>
            <div className="o2-text">o</div>
            <div className="r-text">r</div>
            <div className="s-text">s</div>
          </div>
        </div>
      </div>

      <div className="search-container">
        <div className="search-bar-container"></div>
      </div>
      <div className="practice-colors-component-container">
        {colorQuestions.map((question) => {
          const correctAnswer = question.Answers.$values.find(
            (answer) => answer.IsCorrect
          );
          const answerClass = getColorClass(correctAnswer.Answer);

          return (
            <div key={question.Id} className="practice-colors-card">
              <img src={question.Image} alt="Color" />
              <p className={answerClass}>{correctAnswer.Answer}</p>
            </div>
          );
        })}
      </div>
    </>
  );
}

export default PracticeColorsComponent;



// import React, { useState, useEffect } from "react";
// import "../Styles/practiceColorsComponent.css";
// import { ENDPOINTS } from "../api/apiEndpoints";

// function PracticeColorsComponent() {
//   const [colorQuestions, setColorQuestions] = useState([]);

//   useEffect(() => {
//     fetch(ENDPOINTS.GETCATEGORIESCOLORS)
//       .then((response) => response.json())
//       .then((data) => setColorQuestions(data.$values))
//       .catch((error) =>
//         console.error("Error fetching color questions:", error)
//       );
//   }, []);

//   // Function to map answers to CSS classes
//   const getColorClass = (answer) => {
//     switch (answer.toLowerCase()) {
//       case "orange":
//         return "orange-text";
//       case "blue":
//         return "blue-text";
//       case "red":
//         return "red-text";
//       case "green":
//         return "green-text";
//       case "yellow":
//         return "yellow-text";
//       case "purple":
//         return "purple-text";
//       case "black":
//         return "black-text";
//       case "grey":
//         return "grey-text";
//       case "pink":
//         return "pink-text";
//       case "white":
//         return "white-text";
//       default:
//         return ""; // Default to no color class
//     }
//   };

//   return (

    
//     <div className="practice-colors-component-container">
//       {colorQuestions.map((question) => {
//         const correctAnswer = question.Answers.$values.find(
//           (answer) => answer.IsCorrect
//         );
//         const answerClass = getColorClass(correctAnswer.Answer);

//         return (
//           <div key={question.Id} className="practice-colors-card">
//             <img src={question.Image} alt="Color" />
//             <p className={answerClass}>{correctAnswer.Answer}</p>
//           </div>
//         );
//       })}
//     </div>
//   );
// }

// export default PracticeColorsComponent;

