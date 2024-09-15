import React from "react";
import { useParams } from "react-router-dom";
import AuthorizeView from "../components/authorizeView";
import QuizComponent from "../components/quizComponent";
function Quiz() {
  const { category } = useParams();
  return (
    <>
      <div className="quizPage-container">
        <QuizComponent category={category}></QuizComponent>
      </div>
    </>
  );
}

export default Quiz;
