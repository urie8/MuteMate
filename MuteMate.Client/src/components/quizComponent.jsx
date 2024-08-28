import { useState, useEffect } from "react";
import { useNavigate } from "react-router-dom";
import { ENDPOINTS } from "../api/apiEndpoints";
import "../Styles/quiz.css";

function QuizComponent() {
  const [questions, setQuestions] = useState([]);
  const [currentQuestion, setCurrentQuestion] = useState({});
  const [loading, setLoading] = useState(true);
  const [clicked, setClicked] = useState(false);
  const [questionIndex, setQuestionIndex] = useState(0);
  const apiurl = "http://localhost:5099/api/Quiz/GetCategoryColors";

  useEffect(() => {
    const fetchQuestions = async () => {
      try {
        const res = await fetch(apiurl);
        const data = await res.json();
        setQuestions(data.$values);
      } catch (error) {
        console.log("Error fetching data", error);
      } finally {
        setLoading(false);
      }
    };
    fetchQuestions();
  }, []);

  useEffect(() => {
    if (questions.length > 0) {
      console.log(questions);
      setCurrentQuestion(questions[0]);
    }
  }, [questions]);

  function handleClick() {
    // Check if were at the last question if not keep going through the quiz
    setQuestionIndex(questionIndex + 1);
    console.log(questionIndex);
    setCurrentQuestion(questions[questionIndex]);
    console.log(currentQuestion);
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
                  <button onClick={handleClick} key={index}>
                    {a.Answer}
                  </button>
                ))
              ) : (
                <p>No answers available</p>
              )}
            </div>
          </>
        )}
      </div>
    </>
  );
}

export default QuizComponent;
