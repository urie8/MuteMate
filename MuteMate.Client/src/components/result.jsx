import React, {useEffect, useState}from "react";
import "../Styles/result.css";
import useFetchQuotes from "../hooks/useFetchQuotes";
import banana from "../images/banan1.png";
import { ENDPOINTS } from "../api/apiEndpoints";


function Result({category}) {
  const { quote, error, points } = useFetchQuotes(category);
  const [animalQuestions, setColorAnimals] = useState([]);

  const bananaPoints = () => {
    let bananas = [];
    for (let i = 0; i < points; i++ )
         bananas.push(<img src={banana} alt="banana" className="banana2" key={i} />);

    return bananas;
  }
  useEffect(() => {
    fetch(ENDPOINTS.GETCATEGORIESANIMALS)
      .then((response) => response.json())
      .then((data) => setColorAnimals(data.$values))
      .catch((error) =>
        console.error("Error fetching color questions:", error)
      );
  }, []);


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
        <div className="practice-container">
          <h1 className="practice-text">Here is what you can practice on:</h1>
          <div className="practice-picture">
            
{/* härifrån */}
            <div className="practice-animals-component-container">
        {animalQuestions.slice(0,2).map((question) => {
          const imageUrl = `http://localhost:5237/${question.Image}`; // Full URL for the question image

          const correctAnswer = question.Answers.$values.find(
            (answer) => answer.IsCorrect
          );
        
          return (
            <div key={question.Id} className="practice-animals-card">
              <img
                className="practice-animals-tecken-image"
                src={imageUrl}
                alt="Tecken"
              />

              <div className="grey-line-practice-animals"></div>

              {correctAnswer && (
                <img
                  src={`http://localhost:5237/${correctAnswer.Answer}`}
                  alt="Correct Answer"
                  className="practice-animal-image"
                />
              )}
            </div>
          );
        })}
        </div>
        {/* hit */}
          </div>
        </div>
      </div>
    </>
  );
}

export default Result;
