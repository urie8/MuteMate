import React, { useState } from "react";
// import { useNavigate } from "react-router-dom";
import CategoryPractiseQuiz from "../components/CategoryPractiseQuiz";
function categoryQuiz() {
  return (
    <>
      <CategoryPractiseQuiz message="Quiz" linkTo={"/quiz"} monkeyAnimals="Let´s quiz animals" 
      monkeyLetters="Let´s quiz letters" monkeyColors="Let´s quiz colors" />
    </>
  );
}

export default categoryQuiz;
