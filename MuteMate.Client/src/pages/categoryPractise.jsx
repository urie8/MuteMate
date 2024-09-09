import React, { useState, useEffect } from "react";
import { useNavigate } from "react-router-dom";
import "../categoryPractise.css";
import CategoryPractiseQuiz from "../components/CategoryPractiseQuiz";

function categoryPractise() {
  return (
    <>
      <CategoryPractiseQuiz
        message="Practice"
        linkTo={"/practice"}
        monkeyAnimals="Let´s practice animals"
        monkeyLetters="Let´s practice letters"
        monkeyColors="Let´s practice colors"
      />
    </>
  );
}

export default categoryPractise;
