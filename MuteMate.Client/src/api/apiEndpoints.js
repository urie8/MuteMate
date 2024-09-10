// src/api/apiEndpoints.js

export const API_BASE_URL = "http://localhost:5237"; // Base URL for the API

export const ENDPOINTS = {
  // Authentication
  REGISTER: `${API_BASE_URL}/api/Account/register`,
  LOGIN: `${API_BASE_URL}/api/Account/login`,
  LOGOUT: `${API_BASE_URL}/api/Account/logout`,
  IsAuthenticated: `${API_BASE_URL}/api/Account/isAuthenticated`,
  GETCATEGORIESCOLORS: `${API_BASE_URL}/api/Quiz/GetCategoryColors`,
  GETCATEGORIESLETTERS: `${API_BASE_URL}/api/Quiz/GetCategoryLetters`,
  GETCATEGORIESANIMALS: `${API_BASE_URL}/api/Quiz/GetCategoryAnimals`,
  GET5RANDOMCATEGORIESCOLORS: `${API_BASE_URL}/api/Quiz/Get5RandomCategoryColor`,
  GET5RANDOMCATEGORIESLETTERS: `${API_BASE_URL}/api/Quiz/Get5RandomCategoryLetters`,
  GET5RANDOMCATEGORIESANIMALS: `${API_BASE_URL}/api/Quiz/Get5RandomCategoryAnimals`,
  GETALLUSERSCORRECTANSWERS: `${API_BASE_URL}/CorrectUserAnswers`,
  GETUSERSCORRECTANSWERSCOLORS: `${API_BASE_URL}/CorrectUserAnswersForColors`,
  GETUSERSCORRECTANSWERSLETTERS: `${API_BASE_URL}/CorrectUserAnswersForLetters`,
  GETUSERSCORRECTANSWERSANIMALS: `${API_BASE_URL}/CorrectUserAnswersForAnimals`,
  GETRANDOMPRAISEQUOTE: `${API_BASE_URL}/api/Quote/GetRandomPraiseQuote`,
  GETRANDOMENCOURAGEMENTQUOTE: `${API_BASE_URL}/api/Quote/GetRandomEncouragementQuote`,
  GETQUESTIONSANSWEREDWRONG: `${API_BASE_URL}/api/Quiz/GetQuestionsAnsweredWrong`,
  GETLOGGEDINUSERNAME: `${API_BASE_URL}/api/Account/getLoggedInUser`,
  GETLOGGEDINUSERPOINTS: `${API_BASE_URL}/api/Account/getLoggedInUserPoints`,

  // POST endpoints
  ADDCORRECTUSERANSWERS: `${API_BASE_URL}/api/UserAnswer/AddCorrectUserAnswers`,

  // Add other endpoints here
};
