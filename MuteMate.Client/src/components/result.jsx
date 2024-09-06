import React, { useEffect, useState } from "react";
import "../Styles/result.css";
import useFetchQuotes from "../hooks/useFetchQuotes";
import banana from "../images/banana.png";
import bananaSkugga from "../images/banana-skugga.png";
import happyMonkey from "../images/happyMonkey.png";

const maxPoints = 5;
let correctAnswers = 50;


function Result({ userAnswers }) {
  const [category, setCategory] = useState("");
  const {quote} = useFetchQuotes(category);


  useEffect(() => {
    if (correctAnswers >= 3) {
      setCategory("praise");
    } else {
      setCategory("encouragement");
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

  
  
  // hämta hem bilder och rätt svar på de som de hade fel på.
  // måste hämta hur många rätta (correctAnswers)svar de hade i denna omgången av quiz

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

        {/* om man hade fel, visa vilka de var så att de kan öva */}
        {correctAnswers < maxPoints ? (
          <div className="practise-container">
            <h1 className="practise-text">Let's practice what we missed!</h1>
            <div className="practice-picture">
              {/* //varje userAnswer ska loopas igenom för att söka efter de som ej är korrekt. 
              //Ta id på dem för att fetcha frågan med rätt svar. */}
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
