/* Name: Adetogun Samuel
 * Student-Code: KC-STD-1276
 * Task Title: Task-01
 */


/* SOLUTION TO QUESTION 1.
Declare an integer variable 'numberOfStudents' with an initial value of 25.
print it to the console
*/

int numberOfStudents = 25;

Console.WriteLine(numberOfStudents + "\n");



/* SOLUTION TO QUESTION 2.
 Declare a double variable 'averageHeight' with an initial value of 1.75.
print it's value
*/
double averageHeight = 1.75;

Console.WriteLine(averageHeight + "\n");



/* SOLUTION TO QUESTION 3.
Declare a string variable 'courseName' with an initial value of 'Introduction to C#'.
print a sentence
*/
string courseName = "Introduction to C#";

Console.WriteLine($"Welcome to {courseName} \n");



/* SOLUTION TO QUESTION 4.
Declare a boolean variable 'isClassActive' set it to true.
change it to false.
print the final value.
*/
bool isClassActive = true;

isClassActive = false;

Console.WriteLine("Final Value = {0} \n", isClassActive);



/* SOLUTION TO QUESTION 5.
Declare a character variable "favoriteLetter" set it to any Letter.
print it to the console.
*/
char favoriteLetter = 'S';

Console.WriteLine("favorite Letter = " +  favoriteLetter + ". \n");



/* SOLUTION TO QUESTION 6.
Declare two integer variables 'hoursWorked' (initialised to 40) and 'hourlyRate' (initialised to 25).
Calculate their product and store it in a new integer variable 'grossPay'.
Print grossPay.
*/
int hoursWorked = 40, hourlyRate = 25, grossPay;

grossPay = hoursWorked * hourlyRate;

Console.WriteLine($"GrossPay = {grossPay} \n");



/* SOLUTION TO QUESTION 7.
Declare a Constant Integer 'MAX_ATTEMPTS' initialised to 3, try to change the value and write what you observe.
*/
const int MAX_ATTEMPTS = 3;
//MAX_ATTEMPTS = 5;

// Answer to number 7 : I observe that it throws a compile error that says that MAX_ATTEMPTS must be a variable, property or indexer due to the const keyword.



/* SOLUTION TO QUESTION 8.
What is the default value of double variable if declared but not initialised. Write a code to confirm your answer
*/

double totalAmount;

//Console.WriteLine(totalAmount);
// ANSWER to number 8: It throws a compile error saying "Use of unassigned local variable 'secondPrice' "



/*SOLUTION TO QUESTION 9.
Declare 3 variables 2 strings (bookTitle, authorName) and an int (publicationYear).
Intialised them with favorite book
print book
*/
string bookTitle, authorName;
int publicationYear;

bookTitle = "Tongues: Beyond the Upper Room";
authorName  = "Kenneth E. Hagin";
publicationYear = 2007;

Console.WriteLine($"My favorite book is {bookTitle} by {authorName} published in {publicationYear} \n");



// SOLUTION TO QUESTION 10.
// Declaring and Assigning Several variables to their most appropiate values.
ushort num1 = 52130;
sbyte num2 = -115;
int num3 = 4825932;
sbyte num4 = 97;
short num5 = -10000;
short num6 = 20000;
byte num7 = 224;
uint num8 = 970700000;
sbyte num9 = 112;
sbyte num10 = -44;
int num11 = -1000000;
short num12 = 1990;
long num13 = 123456789123456789;



// SOLUTION TO QUESTION 11.
// Declaring and asigning variables as of type float, double and decimal.
float digit1 = 5;
float digit2 = -5.01f;
double digit3 = 34.567839023;
float digit4 = 12.345f;
double digit5 = 8923.1234857;
decimal digit6 = 3456.091124875956542151256683467m;


/* SOLUTION TO QUESTION 12.
Declare 2 variables of type string with value 'Hello' & 'World'.
Declare a variable of type object. Assign the value obtained of concatenation of the two string to this variable.
Print the variable of type object.
*/
string myWord1 = "Hello", myWord2 = "World";

object sentence = myWord1 + " " + myWord2;

Console.WriteLine(sentence + ".\n");



// 13. Write a program to print a figure in the shape of a heart by the sign 'o'.
Console.WriteLine("  oo  oo  ");
Console.WriteLine("o    o   o");
Console.WriteLine("o        o");
Console.WriteLine("  o    o  ");
Console.WriteLine("     o    ");
Console.WriteLine("\n");



// SOLUTION TO QUESTION 14.
//Declaring Appropriate variables for Employees record.
string firstName = "Samuel";
string lastName = "Adetogun";
byte age = 12;
char gender = 'm';
int employeeNumber = 27564679;



/*SOLUTION TO QUESTION 15.
declaring int variable with intialised value 3600
converting (implicitly) totalSeconds to double variable
printing result to the console
*/
int totalSeconds = 3600;

double totalHours = totalSeconds;

Console.WriteLine($"Total Hours = {totalHours} \n");



/* SOLUTION TO QUESTION 16.
Declaring double variable with initalised value 95.8
Converting (explicitly) to an int
Printing the final result
*/
double totalScore = 95.8;

int finalScore = (int) totalScore;

Console.WriteLine($"Total Score = {totalScore} \n");
Console.WriteLine($"Final Score = {finalScore} \n");
// The reason why both results are different from one another (95.8 and 95) respectively was because
// The double data type accomodates decimal values while the int data type truncate all decimal values and gives a whole number



/* SOLUTION TO QUESTION 17.
Instantiate two integer variables
perfoming integer divisions
Calculating Items Left on the last partial page
*/
int totalItems = 27;
int itemsPerPage = 5;

int fullPage = totalItems / itemsPerPage;
int itemsLeft = totalItems % itemsPerPage;

Console.WriteLine($"full pages = {fullPage} \n");
Console.WriteLine($"items left = {itemsLeft} \n");



// SOLUTION TO QUESTION 18.
//declaring variable with value 0
int counter = 0;
counter += 1;
counter += 1;
counter += 1;
counter += 1;
counter += 1;

Console.WriteLine("Counter = {0} \n", counter);



/* SOLUTION TO QUESTION 19.
declare and intialised two string variables
using comparison operator to check if equal or not
*/
string word1 = "hello", word2 = "Hello";


Console.WriteLine(word1 == word2);
Console.WriteLine();
Console.WriteLine(word2 != word1);
Console.WriteLine();



// SOLUTION TO QUESTION 20A.
bool isLoggedIn = true, isAdmin = false;

Console.WriteLine("Is the User Logged in and also an Administrator? : {0} \n", isLoggedIn && isAdmin);
Console.WriteLine();

// SOLUTION TO QUESTION 20B.
Console.WriteLine("Is the User Logged in or an Administrator? : {0} \n",isLoggedIn || isAdmin);

// SOLUTION TO 20C.
Console.WriteLine("is it an Admin? : {0} \n", !isAdmin);




// SOLUTION TO 21.
//declare and initialised an int variable
int num = 2899821;

//check variable if it's even or odd
if (num % 2 == 0)
{
    Console.WriteLine($"{num} is an even number \n");
}
else
{
    Console.WriteLine($"{num} is an odd number \n");
}



// SOLUTION TO QUESTION 22.
double pi = 3.142;
double r = 8;
double areaOfCircle = pi * r * r;

Console.WriteLine($"Area of a circle = {areaOfCircle} \n");



// SOLUTION TO QUESTION 23A.
int walletBalance = 0;

if (walletBalance > 0)
    Console.WriteLine("You have money! \n");

// SOLUTION TO QUESTION 23B.
if (walletBalance > 0)
{
    Console.WriteLine("You have money! \n");
}
else
{
    Console.WriteLine("Time to earn some money! \n");
}



// SOLUTION TO QUESTION 24A.
int hour = 18;

if (hour == 0)
{
    Console.WriteLine("The time is 12am \n");
}
else if (hour == 1)
{
    Console.WriteLine("The time is 1am \n");
}
else if (hour == 2)
{
    Console.WriteLine("The time is 2am \n");
}
else if (hour == 3)
{
    Console.WriteLine("The time is 3am \n");
}
else if (hour == 4)
{
    Console.WriteLine("The time is 4am \n");
}
else if (hour == 5)
{
    Console.WriteLine("The time is 5am \n");
}
else if (hour == 6)
{
    Console.WriteLine("The time is 6am \n");
}
else if(hour == 7)
{
    Console.WriteLine("The time is 7am \n");
}
else if (hour == 8)
{
    Console.WriteLine("The time is 8am \n");
}
else if (hour == 9)
{
    Console.WriteLine("The time is 9am \n");
}
else if (hour == 10)
{
    Console.WriteLine("The time is 10am \n");
}
else if (hour == 11)
{
    Console.WriteLine("The time is 11am \n");
}
else if (hour == 12)
{
    Console.WriteLine("The time is 12pm \n");
}
else if (hour == 13)
{
    Console.WriteLine("The time is 1pm \n");
}
else if (hour == 14)
{
    Console.WriteLine("The time is 2pm \n");
}
else if (hour == 15)
{
    Console.WriteLine("The time is 3pm \n");
}
else if (hour == 16)
{
    Console.WriteLine("The time is 4pm \n");
}
else if (hour == 17)
{
    Console.WriteLine("The time is 5pm \n");
}
else if (hour == 18)
{
    Console.WriteLine("The time is 6pm \n");
}
else if (hour == 19)
{
    Console.WriteLine("The time is 7pm \n");
}
else if (hour == 20)
{
    Console.WriteLine("The time is 8pm \n");
}
else if (hour == 21)
{
    Console.WriteLine("The time is 9pm \n");
}
else if (hour == 22)
{
    Console.WriteLine("The time is 10pm \n");
}
else if (hour == 23)
{
    Console.WriteLine("The time is 11pm \n");
}



// SOLUTION TO QUESTION 24B
if(hour < 12)
{
    Console.WriteLine("Good morning \n");
}
// SOLUTION TO QUESTION 24C
else if (hour < 18)
{
    Console.WriteLine("Good afternoon \n");
}
// SOLUTION TO QUESTION 24D
else
{
    Console.WriteLine("Good Evening \n");
}

// SOLUTION TO QUESTION 25A
string fruit = "banana";

switch (fruit)
{
    case "apple":
        Console.WriteLine("An apple a day! \n");
        break;
    case "banana":
        Console.WriteLine("Bananas are potassium-rich \n");
        break;
    case "orange":
        Console.WriteLine("Oranges for Vitamin  C \n");
        break;
    default:
        Console.WriteLine($"{fruit} will be added to my list of fruit next time! \n");
        break;
}



//SOLUTION TO QUESTION 25B
switch (fruit)
{
    
    case "apple":
    case "orange":
        Console.WriteLine("This is a common fruit. \n");
        break;
    case "banana":
        Console.WriteLine("This is a long fruit.\n");
        break;
    default:
        Console.WriteLine($"This fruit is unique. \n");
        break;
}