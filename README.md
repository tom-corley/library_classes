# Library Classes

This small project provides three classes used to simulate a library system: 
- `Book`: Domain model for a book, has a title and an author, and a boolean to indicate whether it is available. There are two basic methods `Borrow` and `Return`, which set the availability of a book.
- `Patron`: Domain model for a library customer, each instance has a name, and the ability to borrow and return a specific book.
- `Library`: Class for a library, has a list of each of the following two classes to manage customers and inventory. Implements a variety of utility methods for finding books, adding and removing books and patrons, and seeing the current books or patrons. 

It also contains a file `Program.cs`, which provides example code showing how the above classes can be used to simulate a library.

###  Use Guide
To download the game onto your local machine:
1. Run `git clone https://github.com/tom-corley/library_classes`

To run the example code:
1. Navigate inside the `lib_classes` directory
2. Run `dotnet run`
3. Feel free to experiment with the code and printing things to console.

To run tests:
1. Run `dotnet test` from the root directory of the project

### Testing

The test directory consists of four test files containing unit tests which test the corresponding classes. They are the following:
- `BookTests.cs`
- `PatronTests.cs`
- `LibaryTests.cs`
- `ProgramTests.cs`

These altogether achieve a test coverage of the project files well above 90%.