// import { useState, useEffect } from "react";
// import { useNavigate } from "react-router-dom";
// import { ENDPOINTS } from "../api/apiEndpoints";
// import useFetchQuestions from "../hooks/useFetchQuestions";
// import "../Styles/quiz.css";
// import Result from "./result";

// function QuizComponent({ category }) {
//   const [currentQuestion, setCurrentQuestion] = useState({});
//   const [loading, setLoading] = useState(true);
//   const [questionIndex, setQuestionIndex] = useState(0);
//   const [quizFinished, setQuizFinished] = useState(false);
//   const [selectedAnswer, setSelectedAnswer] = useState(null);
//   const [userAnswers, setUserAnswers] = useState([]);
//   const [submitBtn, setSubmitBtn] = useState(true);

//   const { questions, error } = useFetchQuestions(category);

//   useEffect(() => {
//     if (error) {
//       console.error("Error fetching questions:", error);
//       setLoading(false);
//       return;
//     }

//     if (questions.length > 0) {
//       setCurrentQuestion(questions[0]);
//       setLoading(false);
//     }
//   }, [questions, error]);

//   function handleAnswerClick(answerId, isCorrect) {
//     setSelectedAnswer(isCorrect);
//     setSubmitBtn(false);
//     // When the user clicks an answer, that answers info is saved as an object in useranswers array
//     const userAnswer = {
//       questionId: currentQuestion.Id,
//       answerId: answerId,
//       isCorrect: isCorrect,
//     };

//     setUserAnswers((prevUserAnswers) => [...prevUserAnswers, userAnswer]);

//     console.log(userAnswers);
//     console.log(userAnswer);
//   }

//   function handleNextQuestionClick() {
//     // Reset selected answer state and update the question index
//     setSelectedAnswer(null);
//     // Check if we're at the last question, if not keep going through the quiz
//     if (questionIndex < questions.length - 1) {
//       setQuestionIndex(questionIndex + 1);
//       setCurrentQuestion(questions[questionIndex + 1]);
//       setSubmitBtn(true);
//     } else {
//       setQuizFinished(true);
//       console.log("hi");
//       // TODO: Check if user is logged in, if yes make post request
//       fetch(ENDPOINTS.ADDCORRECTUSERANSWERS, {
//         method: "POST",
//         headers: {
//           "Content-Type": "application/json",
//         },
//         body: JSON.stringify(userAnswers),
//         credentials: "include",
//       })
//         .then((response) => {
//           if (!response.ok) {
//             throw new Error("Network response was not ok");
//           }
//           return response.json();
//         })
//         .then((data) => {
//           console.log("Success:", data);
//         })
//         .catch((error) => {
//           console.error("There was a problem with the fetch operation:", error);
//         });
//     }
//   }

// const getColorClass = (answer) => {
//   switch (answer.toLowerCase()) {
//     case "orange":
//       return "orange-text common-style2";
//     case "blue":
//       return "blue-text common-style2";
//     case "red":
//       return "red-text common-style2";
//     case "green":
//       return "green-text common-style2";
//     case "yellow":
//       return "yellow-text common-style2";
//     case "purple":
//       return "purple-text common-style2";
//     case "black":
//       return "black-text common-style2";
//     case "grey":
//       return "grey-text common-style2";
//     case "pink":
//       return "pink-text common-style2";
//     case "white":
//       return "white-text common-style2";
//     case "brown":
//       return "brown-text common-style2";
//     default:
//       return "";
//   }
// };

//   // Send parameter isCorrect which will be true or false depending on what the user selects
//   const getButtonClass = (isCorrect) => {
//     if (selectedAnswer === null) {
//       return "default-quiz-btn";
//     }
//     return isCorrect ? "correct-quiz-btn" : "incorrect-quiz-btn";
//   };

//   const renderAnswerContent = (answer) => {
//     if (category === "animals") {
//       return (
//         <img
//           src={`http://localhost:5237/${answer.Answer}`}
//           alt="Answer"
//           className="answer-image"
//         />
//       );
//     } else if(category === "colors") {
//       // Om kategorin är "colors", visa svar med tilldelad färgklass
//       const answerColor = getColorClass(answer.Answer);
//       return (
//         <span className={answerColor}>
//           {answer.Answer}
//         </span>
//       );
//     } else {
//       return answer.Answer; // Default to text if no special case
//     }
//   };

//   return (
//     <div className="quiz-wrapper">
//       {loading ? (
//         <h2>Loading...</h2>
//       ) : quizFinished ? (
//         <Result userAnswers={userAnswers} />
//       ) : (
//         <>
//           <h1 className="question-title">
//             {currentQuestion.Question || "No Question Available"}
//           </h1>
//           <h2 className="question-number">Question nr:</h2>
//           <img
//             className="question-img"
//             src={`http://localhost:5237/${currentQuestion.Image}`}
//             alt="Question"
//           />
//           <div className="answer-buttons">
//             {currentQuestion.Answers && currentQuestion.Answers.$values ? (
//               currentQuestion.Answers.$values.map((a, index) => (
//                 <button
//                   className={getButtonClass(a.IsCorrect)}
//                   onClick={(e) => handleAnswerClick(a.Id, a.IsCorrect)}
//                   key={index}
//                   value={a.Id}
//                   disabled={selectedAnswer !== null} // Disable buttons after selection
//                 >
//                   {renderAnswerContent(a)}
//                 </button>
//               ))
//             ) : (
//               <p>No answers available</p>
//             )}
//           </div>
//           <button
//             className="submit-btn"
//             disabled={submitBtn}
//             onClick={handleNextQuestionClick}
//           >
//             Next question
//           </button>
//         </>
//       )}
//     </div>
//   );
// }

// export default QuizComponent;

import { useState, useEffect } from "react";
import { useNavigate } from "react-router-dom";
import { ENDPOINTS } from "../api/apiEndpoints";
import useFetchQuestions from "../hooks/useFetchQuestions";
import "../Styles/quiz.css";
import Result from "./result";


function QuizComponent({ category }) {
  const [currentQuestion, setCurrentQuestion] = useState({});
  const [loading, setLoading] = useState(true);
  const [questionIndex, setQuestionIndex] = useState(0);
  const [quizFinished, setQuizFinished] = useState(false);
  const [selectedAnswer, setSelectedAnswer] = useState(null);
  const [userAnswers, setUserAnswers] = useState([]);
  const [submitBtn, setSubmitBtn] = useState(true);

  const { questions, error } = useFetchQuestions(category);

  useEffect(() => {
    if (error) {
      console.error("Error fetching questions:", error);
      setLoading(false);
      return;
    }

    if (questions.length > 0) {
      setCurrentQuestion(questions[0]);
      setLoading(false);
    }
  }, [questions, error]);

  function handleAnswerClick(answerId, isCorrect) {
    setSelectedAnswer(isCorrect);
    setSubmitBtn(false);
    const userAnswer = {
      questionId: currentQuestion.Id,
      answerId: answerId,
      isCorrect: isCorrect,
    };

    setUserAnswers((prevUserAnswers) => [...prevUserAnswers, userAnswer]);

    console.log(userAnswers);
    console.log(userAnswer);
  }

  function handleNextQuestionClick() {
    setSelectedAnswer(null);

    if (questionIndex < questions.length - 1) {
      setQuestionIndex(questionIndex + 1);
      setCurrentQuestion(questions[questionIndex + 1]);
      setSubmitBtn(true);
    } else {
      setQuizFinished(true);
      console.log("hi");

      fetch(ENDPOINTS.ADDCORRECTUSERANSWERS, {
        method: "POST",
        headers: {
          "Content-Type": "application/json",
        },
        body: JSON.stringify(userAnswers),
        credentials: "include",
      })
        .then((response) => {
          if (!response.ok) {
            throw new Error("Network response was not ok");
          }
          return response.json();
        })
        .then((data) => {
          console.log("Success:", data);
        })
        .catch((error) => {
          console.error("There was a problem with the fetch operation:", error);
        });
    }
  }

  const getColorClass = (answer) => {
    switch (answer.toLowerCase()) {
      case "orange":
        return "orange-text common-style2";
      case "blue":
        return "blue-text common-style2";
      case "red":
        return "red-text common-style2";
      case "green":
        return "green-text common-style2";
      case "yellow":
        return "yellow-text common-style2";
      case "purple":
        return "purple-text common-style2";
      case "black":
        return "black-text common-style2";
      case "grey":
        return "grey-text common-style2";
      case "pink":
        return "pink-text common-style2";
      case "white":
        return "white-text common-style2";
      case "brown":
        return "brown-text common-style2";
      default:
        return "";
    }
  };

  const getButtonClass = (isCorrect) => {
    if (selectedAnswer === null) {
      return "default-quiz-btn";
    }
    return isCorrect ? "correct-quiz-btn" : "incorrect-quiz-btn";
  };

  const renderAnswerContent = (answer) => {
    if (category === "animals") {
      return (
        <img
          src={`http://localhost:5237/${answer.Answer}`}
          alt="Answer"
          className="answer-image"
        />
      );
    } else if (category === "colors") {
      const answerColor = getColorClass(answer.Answer);
      return <span className={answerColor}>{answer.Answer}</span>;
    } else {
      return answer.Answer;
    }
  };

  return (
    <>
      {loading ? (
        <h2>Loading...</h2>
      ) : quizFinished ? (
        <div>
          <Result userAnswers={userAnswers} />
        </div>
      ) : (
        <div className="quiz-wrapper">
          <h1 className="question-title">
            {currentQuestion.Question || "No Question Available"}
          </h1>
          <h2 className="question-number">Question nr:</h2>
          <img
            className="question-img"
            src={`http://localhost:5237/${currentQuestion.Image}`}
            alt="Question"
          />
          <div className="answer-buttons">
            {currentQuestion.Answers && currentQuestion.Answers.$values ? (
              currentQuestion.Answers.$values.map((a, index) => (
                <button
                  className={getButtonClass(a.IsCorrect)}
                  onClick={(e) => handleAnswerClick(a.Id, a.IsCorrect)}
                  key={index}
                  value={a.Id}
                  disabled={selectedAnswer !== null}
                >
                  {renderAnswerContent(a)}
                </button>
              ))
            ) : (
              <p>No answers available</p>
            )}
          </div>
          <button
            className="submit-btn"
            disabled={submitBtn}
            onClick={handleNextQuestionClick}
          >
            Next question
          </button>
        </div>
      )}
    </>
  );
}

export default QuizComponent;
