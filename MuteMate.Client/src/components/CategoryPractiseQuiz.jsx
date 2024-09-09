// import React from "react";
// import { useNavigate } from "react-router-dom";
// import "../categoryPractise.css";

// function CategoryPractiseQuiz({ message, linkTo }) {
//   const navigate = useNavigate();

//   function handleImageClick(category) {
//     //Måste kolla vilken bild som klickats
//     navigate(`${linkTo}/${category}`);
//   }
//   return (
//     <>
//       <div className="page-wrapper">
//         <h2 className="choose-text">{message}</h2>
//         <div className="option-img-container">
//           <div className="img-container">
//             <img
//               className="option-img"
//               src="MiiaImages/color-wheel.png"
//               onClick={() => handleImageClick("colors")}
//             />
//           </div>
//           <div className="img-container">
//             <img
//               className="option-img"
//               src="MiiaImages/abc.png"
//               onClick={() => handleImageClick("letters")}
//             />
//           </div>
//           <div className="img-container">
//             <img
//               className="option-img"
//               src="MiiaImages/livestock.png"
//               onClick={() => handleImageClick("animals")}
//             />
//           </div>
//         </div>
//       </div>
//     </>
//   );
// }

// export default CategoryPractiseQuiz;

import React from "react";
import { useNavigate } from "react-router-dom";
import "../categoryPractise.css";
import happyMonkey from "../images/happyMonkey.png";

function CategoryPractiseQuiz({ message, linkTo, monkeyLetters, monkeyAnimals, monkeyColors }) {
  const navigate = useNavigate();

  function handleImageClick(category) {
    navigate(`${linkTo}/${category}`);
  }

  return (
    <>
      <div className="page-wrapper">
        <h2 className="choose-text">{message}</h2>
        <div className="option-img-container">
          <div className="img-container">
            <div className="img-inner">
              <div className="img-front">
                <img
                  className="option-img"
                  src="MiiaImages/color-wheel.png"
                  alt="Color Wheel"
                  onClick={() => handleImageClick("colors")}
                />
              </div>
              <div
                className="img-back"
                onClick={() => handleImageClick("colors")}
              >
                <h1 className="back-text">{monkeyColors}</h1>
                <img
                  className="thinking-monkey"
                  src={happyMonkey}
                  alt="thinking monkey"
                />
              </div>
            </div>
          </div>
          <div className="img-container">
            <div className="img-inner">
              <div className="img-front">
                <img
                  className="option-img"
                  src="MiiaImages/abc.png"
                  alt="Alphabet"
                  onClick={() => handleImageClick("letters")}
                />
              </div>
              <div
                className="img-back"
                onClick={() => handleImageClick("letters")}
              >
                <h1 className="back-text">{monkeyLetters}</h1>
                <img
                  className="thinking-monkey"
                  src={happyMonkey}
                  alt="thinking monkey"
                />
              </div>
            </div>
          </div>
          <div className="img-container">
            <div className="img-inner">
              <div className="img-front">
                <img
                  className="option-img"
                  src="MiiaImages/livestock.png"
                  alt="Animals"
                  onClick={() => handleImageClick("animals")}
                />
              </div>
              <div
                className="img-back"
                onClick={() => handleImageClick("animals")}
              >
                <h1 className="back-text">{monkeyAnimals}</h1>
                <img
                  className="thinking-monkey"
                  src={happyMonkey}
                  alt="thinking monkey"
                />
              </div>
            </div>
          </div>
        </div>
      </div>
    </>
  );
}

export default CategoryPractiseQuiz;

