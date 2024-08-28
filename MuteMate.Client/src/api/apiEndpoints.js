// src/api/apiEndpoints.js

export const API_BASE_URL = "http://localhost:5099"; // Base URL for the API

export const ENDPOINTS = {
  REGISTER: `${API_BASE_URL}/register`,
  LOGIN: `${API_BASE_URL}/login`,
  GETCATEGORIESCOLORS: `${API_BASE_URL}/api/Quiz/GetCategoryColors`,
  GETCATEGORIESLETTERS: `${API_BASE_URL}/api/Quiz/GetCategoryLetters`,
  GETCATEGORIESANIMALS: `${API_BASE_URL}/api/Quiz/GetCategoryAnimals`,
  GETALLUSERSCORRECTANSWERS: `${API_BASE_URL}/CorrectUserAnswers/{userId}`,
  GETUSERSCORRECTANSWERSCOLORS: `${API_BASE_URL}/CorrectUserAnswersForColors/{userId}`,
  GETUSERSCORRECTANSWERSLETTERS: `${API_BASE_URL}/CorrectUserAnswersForLetters/{userId}`,
  GETUSERSCORRECTANSWERSANIMALS: `${API_BASE_URL}/CorrectUserAnswersForAnimals/{userId}`,

  // Add other endpoints here
};
