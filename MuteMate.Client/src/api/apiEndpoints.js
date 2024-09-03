// src/api/apiEndpoints.js

export const API_BASE_URL = "http://localhost:5237"; // Base URL for the API

export const ENDPOINTS = {
  REGISTER: `${API_BASE_URL}/api/Account/register`,
  LOGIN: `${API_BASE_URL}/api/Account/login`,
  GETCATEGORIESCOLORS: `${API_BASE_URL}/api/Quiz/GetCategoryColors`,
  GETCATEGORIESLETTERS: `${API_BASE_URL}/api/Quiz/GetCategoryLetters`,
  GETCATEGORIESANIMALS: `${API_BASE_URL}/api/Quiz/GetCategoryAnimals`,
  GET5RANDOMCATEGORIESCOLORS: `${API_BASE_URL}/api/Quiz/Get5RandomCategoryColor`,
  GET5RANDOMCATEGORIESLETTERS: `${API_BASE_URL}/api/Quiz/Get5RandomCategoryLetters`,
  GET5RANDOMCATEGORIESANIMALS: `${API_BASE_URL}/api/Quiz/Get5RandomCategoryAnimals`,
  GETALLUSERSCORRECTANSWERS: `${API_BASE_URL}/CorrectUserAnswers/{userId}`,
  GETUSERSCORRECTANSWERSCOLORS: `${API_BASE_URL}/CorrectUserAnswersForColors/{userId}`,
  GETUSERSCORRECTANSWERSLETTERS: `${API_BASE_URL}/CorrectUserAnswersForLetters/{userId}`,
  GETUSERSCORRECTANSWERSANIMALS: `${API_BASE_URL}/CorrectUserAnswersForAnimals/{userId}`,

  // Add other endpoints here
};
