import React, { useState } from "react";
import { useNavigate } from "react-router-dom";
import CategoryPractiseQuiz from "../components/CategoryPractiseQuiz";
function categoryQuiz() {
  return (
    <>
      <CategoryPractiseQuiz message="Let´s quiz" linkTo={"/quiz"} />
    </>
  );
}

export default categoryQuiz;
