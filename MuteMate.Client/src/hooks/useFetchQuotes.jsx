import { useState, useEffect } from "react";
import { ENDPOINTS } from "../api/apiEndpoints";

function useFetchQuotes(category) {
  const [quote, setQuote] = useState("");
  const [error, setError] = useState("");

  useEffect(() => {
    if (!category) return;

    // Vi väljer endpoint baserat på vald kategori
    let endpoint;
    switch (category) {
      case "praise":
        endpoint = ENDPOINTS.GETRANDOMPRAISEQUOTE;
        break;
      case "encouragement":
        endpoint = ENDPOINTS.GETRANDOMENCOURAGEMENTQUOTE;
        break;
      
      default:
        setError("Could not find quotes");
        return;
    }

    const fetchQuestions = () => {
      fetch(endpoint)
        .then((result) => {
          console.log(result);
          if (!result.ok) {
            setError("Could not fetch questions");
          }
          return result.json();
        })
        .then((data) => {
            console.log("data: ", data)
          setQuote(data);
          setError("");
        })
        .catch((err) => {
          setError(err.message);
        });
    };
    fetchQuestions();
  }, [category]);

  return { quote, error };
}

export default useFetchQuotes;
