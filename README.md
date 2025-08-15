# Library Classes

This small project provides three classes used to simulate a library system: 
- `Book`: Domain model for a book, has a title and an author, and a boolean to indicate whether it is available. There are two basic methods `Borrow` and `Return`, which set the availability of a book.
- `Patron`: Domain model for a library customer, each instance has a name, and the ability to borrow and return a specific book.
- `Library`: Class for a library, has a list of each of the following two classes to manage customers and inventory. Implements a variety of utility methods for finding books, adding and removing books and patrons, and seeing the current books or patrons. 

It also contains a file `Program.cs`, which provides example code showing how the above classes can be used to simulate a library. This gives example function calls, and string output making clear the state of the classes after operations have taken place.

###  Use Guide
To download the game onto your local machine:
1. Run `git clone https://github.com/tom-corley/library_classes`

To run the example code:
1. Navigate inside the `lib_classes` directory
2. Run `dotnet run`
3. Feel free to experiment with the code and printing things to console.

To run tests:
1. Run `dotnet test` from the root directory of the project

### Implementation

Exceptions are thrown in the `Book` and `Patron` classes to handle attempts to borrow books which are unavailable, or return those which are already avaialable, or have been borrowed by another Patron. It is reccommended that `try/catch` statements are used when doing these operations if you are unsure whether a book is available.

### Testing

The test directory consists of four test files containing unit tests which test the corresponding classes. They are the following:
- `BookTests.cs`
- `PatronTests.cs`
- `LibaryTests.cs`
- `ProgramTests.cs`

These altogether achieve a test coverage of the project files well above 90%.