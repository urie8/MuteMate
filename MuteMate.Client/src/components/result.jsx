import React from "react";
import "../Styles/result.css";
import useFetchQuotes from "../hooks/useFetchQuotes";


function Result({category}) {
  const { quote, error } = useFetchQuotes(category);
  

  // om det är 3 eller mer bananer- visa berömmande quote (category praise)
  // om det är mellan 0 och 2 bananer så är det en uppmuntrande quote (category encouragement)
//ha en conditional, 1. antingen alla rätt eller
  // 2. visa vilka svar de hade fel på, så att de kan öva.
  // hämta hem från practice, de som de hade fel på.
  return (
    <>
      <div className="main-container">
        <div className="quote-container">
          <h1 className="quote">{quote.Quote}</h1>
        </div>
        <div className="congratsContainer">
          <div className="display-congrats">
            {/* om någon hade alla rätt */}
            <h1 className="congrats-text">You got all 5 bananas!</h1>
          </div>
        </div>
        {/* om man hade fel, visa vilka de var så att de kan öva */}
        <div className="practice-container">
          <h1 className="practice-text">Here is what you can practice on:</h1>
        </div>
      </div>
    </>
  );
};

export default Result;
