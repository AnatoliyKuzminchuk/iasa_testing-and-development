Feature: Epam site Search test
 Background: 
 Given Click on search icon
  Scenario Outline: Frequent searchs check

    Given Choose <Search> from frequent
    When I press enter
    Then I see all blogs about <Result>
    Examples:
      | Search      | Result                                    |
      | Blockchain  | https://www.epam.com/search?q=Blockchain  |
      | Cloud       | https://www.epam.com/search?q=Cloud       |
      | DevOps      | https://www.epam.com/search?q=DevOps       |
      | Open Source | https://www.epam.com/search?q=Open+Source |
      | RPA         | https://www.epam.com/search?q=RPA         |
      | Automation  | https://www.epam.com/search?q=Automation  |
      | Contact     | https://www.epam.com/search?q=Contact     |

  Scenario: Search check
    Given I have entered word "fuck"
    When I press enter
    Then I see "Sorry, but your search returned no results. Please try another query."
    And Near word "BUCK"