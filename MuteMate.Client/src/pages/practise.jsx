

import React from "react";
import { useParams } from "react-router-dom";
import "../Styles/practice.css";
import PracticeColorsComponent from "../components/practiceColorsComponent";

function Practise() {
  const { category } = useParams();

  return (
    <>
      {/* <div className="practice-container">
        <div className="practice-colors-text-container">
          <div className="practice-text">Practice:</div>
          <div className="colors-text-container">
            <div className="c-text">C</div>
            <div className="o-text">o</div>
            <div className="l-text">l</div>
            <div className="o2-text">o</div>
            <div className="r-text">r</div>
            <div className="s-text">s</div>
          </div>
        </div>
      </div>

      <div className="search-container">
        <div className="search-bar-container"></div>
      </div> */}

      {category === "colors" && <PracticeColorsComponent />}
    </>
  );
}

export default Practise;
