

import React from "react";
import { useParams } from "react-router-dom";
import "../Styles/practice.css";
import PracticeColorsComponent from "../components/practiceColorsComponent";
import PracticeAnimalsComponent from "../components/practiceAnimalsComponent";
import PracticeLettersComponent from "../components/practiceLettersComponent";

function Practise() {
  const { category } = useParams();

  return (
    <>
      {category === "colors" && <PracticeColorsComponent />}
      {category === "animals" && <PracticeAnimalsComponent />}
      {category === "letters" && <PracticeLettersComponent />}
    </>
  );
}

export default Practise;
