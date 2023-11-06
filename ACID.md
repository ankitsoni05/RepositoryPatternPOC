**ACID Properties**

What is Transaction ?
- A transaction is a single logical unit of work that accesses and possibly modifies the contents of a database. Transactions access data using read and write operations.

So What is ACID ?
- In order to maintain consistency in a database, before and after the transaction, certain properties are followed. These are called ACID properties. 

![image](https://github.com/ankitsoni05/RepositoryPatternPOC/assets/17673742/10d1654a-a25f-4e5c-8f4b-fbf235439246)

**1. Atomicity**

- By this, we mean that either the entire transaction takes place at once or doesn’t happen at all.
- There is no midway i.e. transactions do not occur partially.
- Each transaction is considered as one unit and either runs to completion or is not executed at all.
- It involves the following two operations.
    1. Abort: If a transaction aborts, changes made to the database are not visible.
    2. Commit: If a transaction commits, changes made are visible. 
Atomicity is also known as the **‘All or nothing rule’**. 
