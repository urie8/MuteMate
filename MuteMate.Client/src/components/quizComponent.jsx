import { useState, useEffect } from "react";
import { useNavigate } from "react-router-dom";
import { ENDPOINTS } from "../api/apiEndpoints";
import useFetchQuestions from "../hooks/useFetchQuestions";
import "../Styles/quiz.css";
import Result from "./result";
import MonkeyReaction from "./monkeyReaction";

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
  }

  function handleNextQuestionClick() {
    setSelectedAnswer(null);
    if (questionIndex < questions.length - 1) {
      setQuestionIndex(questionIndex + 1);
      setCurrentQuestion(questions[questionIndex + 1]);
      setSubmitBtn(true);
    } else {
      setQuizFinished(true);
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

  // Metod för att sätta en klass på färg för answers.
  const getColorClass = (answer) => {
    switch (answer.toLowerCase()) {
      case "orange":
        return "orange-text quiz-common-style";
      case "blue":
        return "blue-text quiz-common-style";
      case "red":
        return "red-text quiz-common-style";
      case "green":
        return "green-text quiz-common-style";
      case "yellow":
        return "yellow-text quiz-common-style";
      case "purple":
        return "purple-text quiz-common-style";
      case "black":
        return "black-text quiz-common-style";
      case "grey":
        return "grey-text quiz-common-style";
      case "pink":
        return "pink-text quiz-common-style";
      case "white":
        return "white-text quiz-common-style";
      case "brown":
        return "brown-text quiz-common-style";
      default:
        return ""; // Default to no color class
    }
  };

  const getButtonClass = (isCorrect, answer) => {
    let baseClass =
      selectedAnswer === null
        ? "default-quiz-btn"
        : isCorrect
        ? "correct-quiz-btn"
        : "incorrect-quiz-btn";

    if (category === "colors") {
      return `${baseClass} ${getColorClass(answer.Answer)}`; // Combine color class with base class
    }

    return baseClass; // For other categories, just return the base class
  };

  const renderAnswerContent = (answer) => {
    if (category === "colors") {
      // For color answers, return only the color class
      return (
        <div className={getColorClass(answer.Answer)}>{answer.Answer}</div>
      );
    } else if (category === "animals") {
      return (
        <img
          src={`http://localhost:5237/${answer.Answer}`}
          // alt="Answer"
          className="answer-image"
        />
      );
    } else {
      return answer.Answer; // Default to text if no special case
    }
  };

  return (
    <div className="quiz-wrapper">
      {loading ? (
        <h2>Loading...</h2>
      ) : quizFinished ? (
        <Result userAnswers={userAnswers} />
      ) : (
        <>
          <h1 className="question-title">
            {currentQuestion.Question || "No Question Available"}
          </h1>
          <img
            className="question-img"
            src={`http://localhost:5237/${currentQuestion.Image}`}
            alt="Question"
          />
          <div className="answer-buttons">
            {currentQuestion.Answers && currentQuestion.Answers.$values ? (
              currentQuestion.Answers.$values.map((a, index) => (
                <button
                  className={getButtonClass(a.IsCorrect, a)}
                  onClick={(e) => handleAnswerClick(a.Id, a.IsCorrect)}
                  key={index}
                  value={a.Id}
                  disabled={selectedAnswer !== null} // Disable buttons after selection
                >
                  {renderAnswerContent(a)}
                </button>
              ))
            ) : (
              <p>No answers available</p>
            )}
          </div>
          <div className="submit-answer-wrapper">
            <button
              className="submit-btn"
              disabled={submitBtn}
              onClick={handleNextQuestionClick}
            >
              Next question
            </button>
            <div className="monkey-answer-reaction">
              <h2 className="monkey-answer-text"></h2>
              <MonkeyReaction isCorrect={selectedAnswer} />
            </div>
          </div>
        </>
      )}
    </div>
  );
}

export default QuizComponent;
