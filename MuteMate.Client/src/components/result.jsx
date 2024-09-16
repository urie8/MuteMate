import React, { useEffect, useState } from "react";
import "../Styles/result.css";
import useFetchQuotes from "../hooks/useFetchQuotes";
import banana from "../images/banana.png";
import bananaSkugga from "../images/banana-skugga.png";
import happyMonkey from "../images/happyMonkey.png";
import { ENDPOINTS } from "../api/apiEndpoints";
import { getColorClass } from "../Utils/colorUtils";

const maxPoints = 5;

function Result({ userAnswers }) {
  const [category, setCategory] = useState("");
  const { quote } = useFetchQuotes(category);
  const [questions, setQuestions] = useState([]);
  const [correctAnswers, setCorrectAnswers] = useState(0);

  useEffect(() => {
    const fetchQuestionsForWrongAnswers = async () => {
      const wrongAnswers = userAnswers.filter((answer) => !answer.isCorrect);
      const wrongQuestionsId = wrongAnswers.map((answer) => answer.questionId);
      const countCorrect = maxPoints - wrongAnswers.length;
      setCorrectAnswers(countCorrect);

      if (wrongQuestionsId.length > 0) {
        try {
          const response = await fetch(
            `${ENDPOINTS.GETQUESTIONSANSWEREDWRONG}?id=${wrongQuestionsId.join(
              ","
            )}`
          );
          const data = await response.json();
          setQuestions(data.$values);
        } catch (error) {
          console.error("Problem fetching the questions", error);
        }
      }
    };
    fetchQuestionsForWrongAnswers();
  }, [userAnswers]);

  useEffect(() => {
    if (correctAnswers <= 2) {
      setCategory("encouragement");
    } else {
      setCategory("praise");
    }
  }, [correctAnswers]);

  const bananaPoints = () => {
    let bananas = [];
    for (let i = 0; i < maxPoints; i++)
      bananas.push(
        <img
          src={i < correctAnswers ? banana : bananaSkugga}
          alt="banana"
          className="banana2"
          key={i}
        />
      );

    return bananas;
  };

  return (
    <>
      <div className="main-container">
        <div className="quote-container">
          <h1 className="quote">{quote.Quote}</h1>
        </div>
        <div className="congrats-container">
          <div className="display-congrats">
            <h1 className="congrats-text">
              Your banana points:{" "}
              <div className="banana-points">{bananaPoints()}</div>
            </h1>
          </div>
        </div>

        {correctAnswers < maxPoints ? (
          <div className="practise-container">
            <h1 className="practise-text">Let's practice what we missed!</h1>
            <div className="practice-picture">
              <div className="practice-letters-component-container">
                {questions.map((question) => {
                  const imageUrl = `http://localhost:5237/${question.Image}`;
                  const correctAnswer = question.Answers?.$values?.[0];

                  return (
                    <div key={question.Id} className="practice-letters-card">
                      <img
                        className="practice-letters-tecken-image"
                        src={imageUrl}
                        alt="Tecken"
                      />

                      <div className="grey-line-practice-letters"></div>

                      {question.Category === "Animals" ? (
                        <img
                          src={`http://localhost:5237/${correctAnswer.Answer}`}
                          alt="Correct Answer"
                          className="practice-animal-image"
                        />
                      ) : question.Category === "Letters" ? (
                        <p className="practice-letter-correct-answer">
                          {correctAnswer.Answer}
                        </p>
                      ) : question.Category === "Colors" ? (
                        <p className={getColorClass(correctAnswer.Answer)}>
                          {correctAnswer.Answer}
                        </p>
                      ) : null}
                    </div>
                  );
                })}
              </div>
            </div>
          </div>
        ) : (
          <div className="monkey-container">
            <img className="monkey" src={happyMonkey} alt="happy monkey" />
          </div>
        )}
      </div>
    </>
  );
}

export default Result;
