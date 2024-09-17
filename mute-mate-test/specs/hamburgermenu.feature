Feature: Hamburger menu

Scenario: Hamburger menu on mobile version
Given that I am on the mobile version of the site with a viewport width of 391px
    And I am on the home page
    When I click on the navbar
    Then the hamburger menu should be visible


Scenario: Redirect to quiz page from hamburger menu
    Given that I am on the mobile version of the site with a viewport width of 391px
    And I am on the home page
    When I click on the navbar
    And I click on the "Quiz" option in the dropdown menu
    Then I should be redirected to the quiz page