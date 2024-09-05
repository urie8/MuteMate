import React, {useEffect, useState}from "react";
import "../Styles/result.css";
import useFetchQuotes from "../hooks/useFetchQuotes";
import banana from "../images/banana.png";
import bananaSkugga from "../images/banana-skugga.png";

const maxPoints = 5;

function Result({category}) {
  const { quote, error, points } = useFetchQuotes(category);
  
  const bananaPoints = () => {
    let bananas = [];
    for (let i = 0; i < maxPoints; i++ )
        
    bananas.push(
      <img
        src={i < points ? banana : bananaSkugga}
        alt="banana"
        className="banana2"
        key={i}
      />
    );

    return bananas;
  }
 

  // om det är 3 eller mer bananer- visa berömmande quote (category praise)
  // om det är mellan 0 och 2 bananer så är det en uppmuntrande quote (category encouragement)
//ha en conditional, 1. antingen alla rätt eller
  // 2. visa vilka svar de hade fel på, så att de kan öva.
  // hämta hem bilder och rätt svar på de som de hade fel på.
  // måste hämta hur många rätta svar de hade i denna omgången av quiz


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
        <div className="practise-container">
          <h1 className="practise-text">Let's practice what we missed!</h1>
          <div className="practice-picture">
            
                        
          </div>
        </div>
      </div>
    </>
  );
}

export default Result;
