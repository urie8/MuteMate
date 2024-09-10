import React, { useState, useEffect, useContext } from "react";
import useFetchQuotes from "../hooks/useFetchQuotes";
import { ENDPOINTS } from "../api/apiEndpoints";
import "../Styles/myPage.css";
import banana from "../images/banan1.png";
import vines from "../images/vines.png";
import { useNavigate } from "react-router-dom";
import colorwheel from "/public/MiiaImages/color-wheel.png";
import alphabet from "/public/MiiaImages/abc.png";
import livestock from "/public/MiiaImages/livestock.png";
import AuthorizeView from "../components/authorizeView";

const maxPoints = 48;
let correctAnswers = 50;
let totalPoints = 10;

//Import från API, användaruppgifter och poäng.

function myPage({}) {
  const [category, setCategory] = useState("");
  const { quote } = useFetchQuotes(category);
  const [userName, setuserName] = useState("");

  useEffect(() => {
    fetch(ENDPOINTS.GETLOGGEDINUSER, {
      method: "GET",
      credentials: "include",
    })
      .then((response) => response.json())
      .then((data) => setuserName(data.username));
  }, []);

  useEffect(() => {
    if (totalPoints >= 25) {
      setCategory("praise");
    } else if (totalPoints <= 25) setCategory("encouragement");
  }, [totalPoints]);

  // Hämta totala poäng från den inloggade spelaren.
  // API

  return (
    <>
      <div className="Container-profile">
        <div className="title-profile-container">
          <h1 className="title-profile"></h1>
          <div className="userNameContainer">
            <div className="display-userName">
              <p>{userName}</p>
            </div>
            {/* Username ska hämtas här */}
          </div>
        </div>
        <div className="quotes-container">
          <h2>{quote.Quote}</h2>
        </div>
        {/*Container för category.
        Container under för att se alla bananer /kategori */}

        <div className="score-display">
          <div className="img-container-profile">
            <img
              src={colorwheel}
              alt="colorwheel"
              className="colorwheel-profile"
            />
            <div className="banana-points-container">
              <img src={banana} alt="banan" className="banana2" />{" "}
              <p className="colorwheel-points"> = 12 </p>
            </div>
          </div>
          <div className="img-container-profile">
            <img src={alphabet} alt="alphabet" className="alphabet-profile" />
            <div className="banana-points-container">
              <img src={banana} alt="banan" className="banana2" />{" "}
              <p className="alphabet-points"> = 12 </p>
            </div>
          </div>
          <div className="img-container-profile">
            <img src={livestock} alt="animals" className="animals-profile" />
            <div className="banana-points-container">
              <img src={banana} alt="banan" className="banana2" />{" "}
              <p className="animal-points"> = 12 </p>
            </div>
          </div>
        </div>
        <div className="banana-Mobile-container">
          <p className="banana-text-1">Your total bananas!</p>
          <div className="banana-display-mobile">
            <img src={banana} alt="banan" className="bananaMobile" />{" "}
            <p className="Total-bananas-text"> {totalPoints}</p>
          </div>
        </div>
        {/* <div className="banana-display"> */}
        {/* <div className="banana-text">Total bananas!</div>
        <img src={banana} alt="banan" className="banana1" /> */}
        {/* <div className="banana-point">Hämta bananer här från API</div> */}
        {/* </div> */}
      </div>
    </>
  );
}

export default myPage;
