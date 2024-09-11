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

//Import från API, användaruppgifter och poäng.

function myPage({}) {
  const [loading, setLoading] = useState(true); // State to manage loading
  const [loadingColors, setLoadingColors] = useState(true);
  const [loadingLetters, setLoadingLetters] = useState(true);
  const [loadingAnimals, setLoadingAnimals] = useState(true);
  const [error, setError] = useState(""); // State to manage errors
  const [userName, setuserName] = useState("");
  const [correctAnswers, setCorrectAnswers] = useState([]);
  const [correctAnswersColors, setCorrectAnswersColors] = useState([]);
  const [correctAnswersLetters, setCorrectAnswersLetters] = useState([]);
  const [correctAnswersAnimals, setCorrectAnswersAnimals] = useState([]);
  const [category, setCategory] = useState("");
  const { quote } = useFetchQuotes(category);

  useEffect(() => {
    fetch(ENDPOINTS.GETLOGGEDINUSERNAME, {
      method: "GET",
      credentials: "include",
    })
      .then((response) => response.json())
      .then((data) => setuserName(data.username));
  }, []);

  useEffect(() => {
    const fetchCorrectAnswers = async () => {
      try {
        const response = await fetch(ENDPOINTS.GETALLUSERSCORRECTANSWERS, {
          method: "GET",
          credentials: "include", // Important for sending cookies
        });

        if (response.ok) {
          const data = await response.json();
          setCorrectAnswers(data); // Set the correct answers data in state
        } else {
          setError("Failed to load correct answers");
        }
      } catch (error) {
        console.error("Error fetching correct answers", error);
        setError("Error fetching correct answers");
      } finally {
        setLoading(false); // Stop loading once data is fetched
      }
    };
    fetchCorrectAnswers();
  }, []); // Run this effect once when the component mounts

  // This effect will run when totalBananas is updated
  const totalBananas = correctAnswers.length;

  useEffect(() => {
    if (totalBananas >= 25) {
      setCategory("praise");
    } else {
      setCategory("encouragement");
    }
  }, [totalBananas]);

  useEffect(() => {
    console.log("Fetching from this ", ENDPOINTS.GETUSERSCORRECTANSWERSCOLORS);
    const fetchCorrectAnswersColors = async () => {
      try {
        const response = await fetch(ENDPOINTS.GETUSERSCORRECTANSWERSCOLORS, {
          method: "GET",
          credentials: "include", // Important for sending cookies
        });
        if (response.ok) {
          const data = await response.json();
          console.log("API RESPONSE:", data);
          const correctAnswersC = data.$values || [];
          console.log("Correct Answers:", correctAnswersC);
          setCorrectAnswersColors(correctAnswersC); // Set the correct answers data in state
        } else {
          setError("Failed to load correct answers");
        }
      } catch (error) {
        console.error("Error fetching correct answers", error);
        setError("Error fetching correct answers");
      } finally {
        setLoadingColors(false); // Stop loading once data is fetched
      }
    };
    fetchCorrectAnswersColors();
  }, []);

  const totalPointsColors = correctAnswersColors.length;

  useEffect(() => {
    console.log("Fetching from this ", ENDPOINTS.GETUSERSCORRECTANSWERSLETTERS);
    const fetchCorrectAnswersLetters = async () => {
      try {
        const response = await fetch(ENDPOINTS.GETUSERSCORRECTANSWERSLETTERS, {
          method: "GET",
          credentials: "include", // Important for sending cookies
        });
        if (response.ok) {
          const data = await response.json();
          console.log("API RESPONSE:", data);
          const correctAnswersL = data.$values || [];
          console.log("Correct Answers:", correctAnswersL);
          setCorrectAnswersLetters(correctAnswersL); // Set the correct answers data in state
        } else {
          setError("Failed to load correct answers");
        }
      } catch (error) {
        console.error("Error fetching correct answers", error);
        setError("Error fetching correct answers");
      } finally {
        setLoadingLetters(false); // Stop loading once data is fetched
      }
    };
    fetchCorrectAnswersLetters();
  }, []);

  const totalPointsLetters = correctAnswersLetters.length;

  useEffect(() => {
    console.log("Fetching from this ", ENDPOINTS.GETUSERSCORRECTANSWERSANIMALS);
    const fetchCorrectAnswersAnimals = async () => {
      try {
        const response = await fetch(ENDPOINTS.GETUSERSCORRECTANSWERSANIMALS, {
          method: "GET",
          credentials: "include", // Important for sending cookies
        });
        if (response.ok) {
          const data = await response.json();
          console.log("API RESPONSE:", data);
          const correctAnswersA = data.$values || [];
          console.log("Correct Answers:", correctAnswersA);
          setCorrectAnswersAnimals(correctAnswersA); // Set the correct answers data in state
        } else {
          setError("Failed to load correct answers");
        }
      } catch (error) {
        console.error("Error fetching correct answers", error);
        setError("Error fetching correct answers");
      } finally {
        setLoadingAnimals(false); // Stop loading once data is fetched
      }
    };
    fetchCorrectAnswersAnimals();
  }, []);

  const totalPointsAnimals = correctAnswersAnimals.length;

  if (loading || loadingColors || loadingLetters || loadingAnimals) {
    return <div>Loading...</div>; // Show a loading state while fetching data
  }

  if (error) {
    return <div>{error}</div>; // Display error message if there's any error
  }

  // useEffect(() => {
  //   if (totalBananas.length >= 25) {
  //     setCategory("praise");
  //   } else if (totalBananas <= 25) setCategory("encouragement");
  // }, [totalBananas]);

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
              <p className="colorwheel-points">= {totalPointsColors}</p>
            </div>
          </div>
          <div className="img-container-profile">
            <img src={alphabet} alt="alphabet" className="alphabet-profile" />
            <div className="banana-points-container">
              <img src={banana} alt="banan" className="banana2" />{" "}
              <p className="alphabet-points"> = {totalPointsLetters}</p>
            </div>
          </div>
          <div className="img-container-profile">
            <img src={livestock} alt="animals" className="animals-profile" />
            <div className="banana-points-container">
              <img src={banana} alt="banan" className="banana2" />{" "}
              <p className="animal-points"> = {totalPointsAnimals}</p>
            </div>
          </div>
        </div>
        <div className="banana-Mobile-container">
          <p className="banana-text-1">Your total bananas!</p>
          <div className="banana-display-mobile">
            <img src={banana} alt="banan" className="bananaMobile" />{" "}
            <p className="Total-bananas-text"> = {totalBananas}</p>
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
