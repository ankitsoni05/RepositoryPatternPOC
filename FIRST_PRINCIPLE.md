**F.I.R.S.T. acronym for better unit tests**

Good unit tests have some properties in common: 
1. F - Fast
2. I - Independent
3. R - Repeatable
4. S - Self-validating
5. T - Thorough

**FAST**

  1. The developer shouldn’t hesitate to run the run the unit tests at any point of their development cycle, even if there are thousands of unit tests. They should run and show you the desired output in a matter of seconds
  2. You should not create tests that require a long time for setup and start-up: ideally, you should be able to run the whole test suite in under a minute.

**Independent (or isolated)**

  1. For any given unit test, for its environment variables or for its setup. It should be independent of everything else should so that it results is not influenced by any other factor.
  2. Should follow the 3 A’s of testing: Arrange, Act, Assert
      In some literature, it’s also called as Given, when, then.
      Arrange:- All the data should be provided to the test when you’re about to run the test and it should not depend on the environment you are running the tests
      Act:- Invoke the actual method under test
      Assert:- At any given point, a unit test should only assert one logical outcome, multiple physical asserts can be part of this physical assert, as long as they all act on the state of the same object.
Preferably, don’t do any actions after the assert call

example :- 

MyObject myObj = null;

[Fact]
void Test1()
{
    myObj = new MyObject(); //issue prone area
    Assert.True(string.IsNullOrEmpty(myObj.MyProperty));
}

[Fact]
void Test2()
{
    myObj.MyProperty = "ciao"; // Dependency
    Assert.Equal("oaic", Reverse(myObj.MyProperty));
}

**Repeatable**

  1. Tests should be repeatable and deterministic, their values shouldn’t change based on being run on different environments.
  2. Each test should set up its own data and should not depend on any external factors to run its test

**Self Validating**

  1. Self-validating means that a test should perform operations and programmatically check for the result.
  2. For instance, if you’re testing that you’ve written something on a file, the test itself is in charge of checking that it worked correctly. No manual operations should be done.

**Thorough**

  1. Should cover all the happy paths
  2. Try covering all the edge cases, where the author would feel the function would fail.
  3. Test for illegal arguments and variables.
  4. Test for security and other issues
  5. Test for large values, what would a large input do their program.
  6. Should try to cover every use case scenario and not just aim for 100% code coverage.
