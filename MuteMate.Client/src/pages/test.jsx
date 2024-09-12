import React, { useEffect, useState } from "react";
import Result from "../components/result";
import Spinner from "../components/spinner";
import { ENDPOINTS } from "../api/apiEndpoints";

function Test() {
  const [isLoading, setIsLoading] = useState(true);
  const [data, setData] = useState(null);

  useEffect(() => {
    setTimeout(() => {
      fetch(ENDPOINTS.GETCATEGORIESLETTERS)
        .then((response) => response.json())
        .then((data) => {
          setData(data.$values);
          setIsLoading(false); // När datan är laddad, ändra tillståndet
        })
        .catch((error) => {
          console.error("Error fetching data:", error);
          setIsLoading(false); // Ändra tillståndet även vid fel
        });
    }, 2000); // 2 sekunders fördröjning
  }, []);

  return (
    <>
      <Result />
      {isLoading ? (
        <Spinner />
      ) : (
        <div>
          <h1>Data är laddad!</h1>
          <pre>{JSON.stringify(data, null, 2)}</pre>
        </div>
      )}
    </>
  );
}
export default Test;
