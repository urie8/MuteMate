import React from "react";
import { useParams } from "react-router-dom";
import AuthorizeView from "../components/authorizeView";
import QuizComponent from "../components/quizComponent";
function Quiz() {
  const { category } = useParams();
  return (
    <>
      <div className="quizPage-container">
        <AuthorizeView>
          <QuizComponent category={category}></QuizComponent>
        </AuthorizeView>
      </div>
    </>
  );
}

export default Quiz;
