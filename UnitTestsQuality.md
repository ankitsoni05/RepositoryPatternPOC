**Why Write Automated Tests ?**  
  1. Breaking Existing tests if changes happened
  2. End Users Happy
  3. Reduce the cost of software development.
  4. Long Term speed of development.
  5. Quick to execute
  6. Greater confidence that software is working .

**Three logical phases of test methods**
  1. **Arrange :-** Setting the test objects, initialize the test data etc
  2. **Act :-** Call Method, set property, etc
  3. **Assert :-** Compare returned value/ end state with expected.

What are the qualities of good unit test ?
A good unit test possesses several characteristics that collectively contribute to its effectiveness in ensuring the reliability and quality of code. Here's what makes a unit test "good":
1. Isolation: A unit test should isolate the unit of code being tested from external dependencies and interactions. This ensures that failures are localized to the unit under test.
2. Independence: Unit tests should be independent of each other. The outcome of one test should not affect the outcome of another test.
3. Fast Execution: Unit tests should be fast to execute, enabling frequent testing during development without causing significant delays.
4. Clear Purpose: Each test should have a clear and specific purpose, focusing on a single behaviour or aspect of the code.
5. Predictable Results: A unit test should produce the same results every time it is executed, regardless of the testing environment.
6. Readability: Tests should be easy to read and understand. A well-written test serves as documentation for the expected behaviour of the code.
7. Coverage: A good unit test provides good coverage of the code it's testing. It exercises various code paths and edge cases.
8. Maintainability: Tests should be maintainable as the codebase evolves. Changes in the code should require corresponding updates to the tests.
9. Descriptive Assertions: Assertions in the test should be descriptive and clearly state the expected behaviour.
10. Mocking and Stubbing: Use mocking or stubbing to simulate dependencies and isolate the code being tested.
11. Test Naming: Meaningful and descriptive test names make it clear what behaviour is being tested.
12. Arrange-Act-Assert (AAA) Pattern: Organize tests using the AAA pattern: Arrange (set up the test environment), Act (trigger the behaviour under test), and Assert (validate the expected outcome).
13. Fast Feedback Loop: A good unit test provides quick feedback to developers about the correctness of their code changes.
14. Cover Edge Cases: Test a variety of inputs, including edge cases and boundary conditions, to ensure robust behaviour.
15. Version Control Integration: Unit tests should be part of version control, allowing the team to track changes in test coverage over time.
16. Integration Testing Separation: Focus on unit tests for isolated units of code, leaving more comprehensive integration tests to separate test suites.

In summary, a good unit test is characterized by its ability to accurately test a specific piece of code, provide rapid feedback, and contribute to maintaining a reliable and maintainable codebase.

