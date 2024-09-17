import { Given, When, Then } from "@badeball/cypress-cucumber-preprocessor";

Given("that I am on the Practice Page letters", () => {
  cy.visit("/practice/letters");
});

When("I click on the Searchbar on the practice letters page", () => {
  cy.get(".search-input").should("be.visible").click();
});

When(
  "I type in {string} in the Searchbar on the practice letters page",
  (a) => {
  cy.get(".search-input").clear().type(a);
  }
);

Then("I should see the {string} sign on the letters practice page", (a) => {
cy.get(".practice-letters-tecken-image").should("be.visible");});
