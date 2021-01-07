# Exercise 4: For and Foreach Loops

This is an exercise for the coursera course [More C# Programming and Unity](https://www.coursera.org/learn/more-programming-unity)

### Getting Started

Double-click the index file in the Help folder and click the ConsoleCards link in the pane on the left; this is the documentation for the classes I provided to you in the ConsoleCards dll.

### Problem 1 - Print numbers in user-selected range

Start up the IDE and create a new Console Application project named Exercise4. Save the project in a reasonable location on the computer.

Prompt for and get lower and upper bounds for numbers to print.

Use a for loop to print the numbers between the lower and upper bound (inclusive)

### Problem 2 - Create objects

Follow the instructions for your IDE from the Adding a DLL lecture to add the ConsoleCards.dll from the zip file as a reference for your project.

Inside the **Main** method, declare a deck variable and create a new **Deck** object for that variable.

Inside the **Main** method, declare a list variable that will hold a hand of cards and create a new list object for that variable.

Tell the deck to shuffle itself.

### Problem 3 - Deal and print the cards in a hand using for and foreach loops

Use a for loop to deal 5 cards from the deck to the hand

Use a for loop to flip all the cards in the hand over. Do NOT hard-code 5 as the upper limit of the loop.

Use a foreach loop (not a for loop) to print all the cards in the hand (remember, the **Card** class exposes a **Print** method).
 
## Installation
To install, follow these steps:

Via Downloading from GitHub:

Download this repository onto your machine by clicking the "Clone or Download" button or Fork the repo into your own Github account
Download and extract the zip file to a directory of your choice.  

Via command line:

`$ git clone https://github.com/puglisac/coursera c-sharp-2-ex4.git`

Open the file "Exercise4.sln"