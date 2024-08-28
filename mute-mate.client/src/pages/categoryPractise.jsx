import React, { useState, useEffect } from "react";
import { useNavigate } from "react-router-dom";
import "../categoryPractise.css";
import CategoryPractiseQuiz from "../components/CategoryPractiseQuiz";

function categoryPractise() {
  return (
    <>
      <CategoryPractiseQuiz message="Let´s practise!" linkTo={"/practise"} />
    </>
  );
}

export default categoryPractise;
