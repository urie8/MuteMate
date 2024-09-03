import { useState, useEffect } from "react";
import { useNavigate } from "react-router-dom";
import { ENDPOINTS } from "../api/apiEndpoints";
import useFetchQuestions from "../hooks/useFetchQuestions";
import "../Styles/quiz.css";

function QuizComponent({ category }) {
  // const [questions, setQuestions] = useState([]);
  const [currentQuestion, setCurrentQuestion] = useState({});
  const [loading, setLoading] = useState(true);
  const [questionIndex, setQuestionIndex] = useState(1);
  const [quizFinished, setQuizFinished] = useState(false);
  const [AnswerBtnStyle, setAnswerBtnStyle] = useState("default-quiz-btn");
  const [submitBtn, setSubmitBtn] = useState(true);

  const { questions, error } = useFetchQuestions(category);

  // Temporary url for testing
  // const apiurl = "http://localhost:5237/api/Quiz/GetCategoryColors";

  // useEffect(() => {
  //   const fetchQuestions = async () => {
  //     try {
  //       const res = await fetch(apiurl);
  //       const data = await res.json();
  //       setQuestions(data.$values);
  //     } catch (error) {
  //       console.log("Error fetching data", error);
  //     } finally {
  //       setLoading(false);
  //     }
  //   };
  //   fetchQuestions();
  // }, []);

  // useEffect(() => {
  //   if (questions.length > 0) {
  //     console.log(questions);
  //     setCurrentQuestion(questions[0]);
  //     console.log(category);
  //   }
  // }, [questions]);

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

  function handleAnswerClick(e) {
    console.log(e.target.value);

    if (e.target.value == "true") {
      e.target.className = "correct-quiz-btn";
    } else {
      e.target.className = "incorrect-quiz-btn";
    }

    setSubmitBtn(false);
  }

  function handleNextQuestionClick() {
    // Check if were at the last question if not keep going through the quiz
    if (questionIndex <= questions.length) {
      setQuestionIndex(questionIndex + 1);
      setCurrentQuestion(questions[questionIndex]);
      setSubmitBtn(true);
      setAnswerBtnStyle("default-quiz-btn");
    } else {
      // Pull up finished quiz page
    }
  }

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
                    className={AnswerBtnStyle}
                    onClick={handleAnswerClick}
                    key={index}
                    value={a.IsCorrect}
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
