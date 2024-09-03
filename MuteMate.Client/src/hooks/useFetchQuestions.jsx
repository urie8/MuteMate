import { useState, useEffect } from "react";
import { ENDPOINTS } from "../api/apiEndpoints";

function useFetchQuestions(category) {
  const [questions, setQuestions] = useState([]);
  const [error, setError] = useState("");

  useEffect(() => {
    if (!category) return;

    // Vi väljer endpoint baserat på vald kategori
    let endpoint;
    switch (category) {
      case "colors":
        endpoint = ENDPOINTS.GET5RANDOMCATEGORIESCOLORS;
        break;
      case "letters":
        endpoint = ENDPOINTS.GET5RANDOMCATEGORIESLETTERS;
        break;
      case "animals":
        endpoint = ENDPOINTS.GET5RANDOMCATEGORIESANIMALS;
        break;
      default:
        setError("Could not find category");
        return;
    }

    const fetchQuestions = () => {
      fetch(endpoint)
        .then((result) => {
            console.log(result)
          if (!result.ok) {
            setError("Could not fetch questions");
          }
          return result.json();
        })
        .then((data) => {
            console.log(data.$values)
          setQuestions(data.$values);
          setError(""); 
        })
        .catch((err) => {
          setError(err.message);
        });
    };
    fetchQuestions();
  }, [category]);

  return { questions, error };
}

export default useFetchQuestions;
