import { useState, useEffect } from "react";
import { useNavigate } from "react-router-dom";
import { ENDPOINTS } from "../api/apiEndpoints";
import useFetchQuestions from "../hooks/useFetchQuestions";
import "../Styles/quiz.css";

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

  function handleAnswerClick(e, isCorrect) {
    setSelectedAnswer(isCorrect);
    setSubmitBtn(false);
    // When the user clicks an answer, that answers info is saved as an object in useranswers array
    const userAnswer = {
      questionId: currentQuestion.Id,
      answerId: parseInt(e.target.value),
    };
    setUserAnswers((prevUserAnswers) => [...prevUserAnswers, userAnswer]);

    console.log(userAnswers);
    console.log(userAnswer);
  }

  function handleNextQuestionClick() {
    // Reset selected answer state and update the question index
    setSelectedAnswer(null);
    // Check if we're at the last question, if not keep going through the quiz
    if (questionIndex < questions.length - 1) {
      setQuestionIndex(questionIndex + 1);
      setCurrentQuestion(questions[questionIndex + 1]);
      setSubmitBtn(true);
    } else {
      setQuizFinished(true);
      console.log("hi");
      // Make a post request to the API with the current users answers
    }
  }

  // Send parameter isCorrect which will be true or false depending on what the user selects
  const getButtonClass = (isCorrect) => {
    if (selectedAnswer === null) {
      return "default-quiz-btn";
    }
    return isCorrect ? "correct-quiz-btn" : "incorrect-quiz-btn";
  };

  return (
    <>
      <div className="quiz-wrapper">
        {loading ? (
          <h2>Loading...</h2>
        ) : (
          <>
            <h1 className="question-title">
              {currentQuestion.Question || "No Question Available"}
            </h1>
            <img className="question-img" src={currentQuestion.img} />
            <div className="answer-buttons">
              {currentQuestion.Answers && currentQuestion.Answers.$values ? (
                currentQuestion.Answers.$values.map((a, index) => (
                  <button
                    className={getButtonClass(a.IsCorrect)}
                    onClick={(e) => handleAnswerClick(e, a.IsCorrect)}
                    key={index}
                    value={a.Id}
                    disabled={selectedAnswer !== null} // Disable buttons after selection
                  >
                    {a.Answer}
                  </button>
                ))
              ) : (
                <p>No answers available</p>
              )}
            </div>
            <button disabled={submitBtn} onClick={handleNextQuestionClick}>
              Next question
            </button>
          </>
        )}
        {quizFinished}
      </div>
    </>
  );
}

export default QuizComponent;
