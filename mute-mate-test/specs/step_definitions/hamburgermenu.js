import { Given, When, Then } from "@badeball/cypress-cucumber-preprocessor";

Given(
  "that I am on the mobile version of the site with a viewport width of 391px",
  () => {
    cy.viewport(390, 800); // Set viewport width to 391px and height to 800px (or any appropriate height)
  }
);

Given("I am on the home page", () => {
  cy.visit("/"); // Adjust the URL if your home page is different
});

When("I click on the navbar", () => {
  cy.get(".hamburger-react").click(); // Adjust the selector to match your hamburger menu's class or ID
});

Then("the hamburger menu should be visible", () => {
  cy.get(".dropdown-menu").should("be.visible"); // Adjust the selector to match your hamburger menu's class or ID
});

When("I click on the {string} option in the dropdown menu", (a) => {
  cy.get('.dropdown-menu > [href="/categoryQuiz"]').click();
});

Then("I should be redirected to the quiz page", () => {
cy.url().should("include", "/categoryQuiz");});
