
Random dice = new();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3= dice.Next(1, 7);


int total = roll1 + roll2+ roll3;

Console.WriteLine($"Dice rolls: {roll1} + {roll2} + {roll3} = {total}");

if ( (roll1== roll2) || (roll1 == roll3) || (roll2 ==  roll3)){
    Console.WriteLine("You rolled double! +2 bonus to the total");
    total += 2;
}

if (total > 15){
    Console.WriteLine("You win!");
}

if (total < 150){
    Console.WriteLine("Sorry but you Lose!");
}

Console.Clear();

// The arrays section 

int[] numberArray = new int[5];   // create a integer array that has predefined memory or 5 integer elements.
 
// initialize the array using its indexes.
numberArray[0] = 1;
numberArray[1] = 2;
numberArray[2] = 3;
numberArray[3] = 4;
numberArray[4] = 5;

// access and print the elemnet at index zero of the array.
Console.WriteLine($"The element at index 0 is {numberArray[0]}"); 

Console.Clear(); // clear the console

string[] names = {"Lungile", "Adam", "Mpumie"}; // create and initialize the array with some values 

Console.WriteLine($"There are {names.Length} people in the list.");
Console.WriteLine($"The name of the programmer is {names[0]}");

// reasign the elements in an array 


names[1] = "Wisdom";
names[2] = "Nompumelelo";

Console.WriteLine($"The new names in the list are {names[0]}, {names[1]}, and {names[2]} ");

// lets get the names in the lists and the qualifications of each person using parallel arrays 

string[] qualification = new string[3];

qualification[0] = "Full-Stack Developer";
qualification[1] = "Programmer";
qualification[2] = "Front-End Developer";

for (int i = 0 ; i < qualification.Length ; i++){
    Console.WriteLine($"{names[i]} is a certified {qualification[i]}");
}


// Could that be easier using a foreach loop? 
char[] grades = {'A' , 'B', 'C'};

foreach (char grade in grades) {
    Console.WriteLine($"You could possible become an {grade} grade C# programmer.");
}


Console.Clear();
// Code challenge - Report the Order IDs that need further investigation



// STEP 1: Declare an array and initialize it to contain the following elements
// B123 C234 A345 C156 B177 G3003 C235 B179

string[] fradulentOrderId = {"B123", "C234" , "A345", "C156" , "B177"  , "G3003", "C235", "B179"};


// STEP 2: Create a foreach statement to iterate through each element of your array.

foreach(string id in fradulentOrderId){
    if (id.StartsWith("B")) {
        Console.WriteLine(id); // onlu prints if the ID starts with B
    }
}

// STEP #: Report the Order IDs that start with the letter "B". -- this is done on the foreach loop

// WRITING COMMENTS THE RIGHT WAY 

Random random = new Random();
string[] orderIDs = new string[5];
// Loop through each blank orderID
for (int i = 0; i < orderIDs.Length; i++)
{
    // Get a random value that equates to ASCII letters A through E
    int prefixValue = random.Next(65, 70);
    // Convert the random value into a char, then a string
    string prefix = Convert.ToChar(prefixValue).ToString();
    // Create a random number, pad with zeroes
    string suffix = random.Next(1, 1000).ToString("000");
    // Combine the prefix and suffix together, then assign to current OrderID
    orderIDs[i] = prefix + suffix;
}
// Print out each orderID
foreach (var orderID in orderIDs)
{
    Console.WriteLine(orderID);
}

Console.Clear();

/* The following code counts how many times the character 'o' appears on a text*/

// variable that stores the text to search through
string someText = "I am out hear, somewhere in the corner of South Africa trying to make the best programmer in C#";

// convert someText's elements to a char array to make it easy to count the 'o's
char[] characters = someText.ToCharArray();

// reverse the elements of the array - not necessary 
Array.Reverse(characters); 

// count is the variable that will hold the number of 'o's of the iteration
int count =0; 

foreach (char character in characters){

    if (character == 'o'){
        count++;
    }
}

Console.WriteLine($"There are {count} o's in \"{someText}\"");

Console.Clear();
// Second guided Project 

/*In this guided project, you'll use Visual Studio Code to develop a C# application. The application will use arrays, foreach statements, and if statements to implement a list of design parameters. You'll begin by creating the array variables that contain your application data. To complete the project, you'll develop foreach and if statements that implement the application design goals.*/

/* The following list shows the letter grade that corresponds to numeric scores: 

97 - 100   A+
93 - 96    A
90 - 92    A-
87 - 89    B+
83 - 86    B
80 - 82    B-
77 - 79    C+
73 - 76    C
70 - 72    C-
67 - 69    D+
63 - 66    D
60 - 62    D-
0  - 59    F*/

// The update application needs to produce a formatted student grading report that appears as follows:

/* 
Student         Grade

Sophia:         92.2    A-
Andrew:         89.6    B+
Emma:           85.6    B
Logan:          91.2    A-
 */ 

// initialize variables - graded assignments 
/*
int currentAssignments = 5;

int sophia1 = 90;
int sophia2 = 86;
int sophia3 = 87;
int sophia4 = 98;
int sophia5 = 100;

int andrew1 = 92;
int andrew2 = 89;
int andrew3 = 81;
int andrew4 = 96;
int andrew5 = 90;

int emma1 = 90;
int emma2 = 85;
int emma3 = 87;
int emma4 = 98;
int emma5 = 68;

int logan1 = 90;
int logan2 = 95;
int logan3 = 87;
int logan4 = 88;
int logan5 = 96;

int sophiaSum = 0;
int andrewSum = 0;
int emmaSum = 0;
int loganSum = 0;

decimal sophiaScore;
decimal andrewScore;
decimal emmaScore;
decimal loganScore;

sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
andrewSum = andrew1 + andrew2 + andrew3 + andrew4 + andrew5;
emmaSum = emma1 + emma2 + emma3 + emma4 + emma5;
loganSum = logan1 + logan2 + logan3 + logan4 + logan5;

sophiaScore = (decimal)sophiaSum / currentAssignments;
andrewScore = (decimal)andrewSum / currentAssignments;
emmaScore = (decimal)emmaSum / currentAssignments;
loganScore = (decimal)loganSum / currentAssignments;

Console.WriteLine("Student\t\tGrade\n");
Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA-");
Console.WriteLine("Andrew:\t\t" + andrewScore + "\tB+");
Console.WriteLine("Emma:\t\t" + emmaScore + "\tB");
Console.WriteLine("Logan:\t\t" + loganScore + "\tA-");

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine(); */


// lets improve how the code above is written....

// initialize variables - graded assignments 
int currentAssignments = 5;

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96 };

// Student names
string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

int[] studentScores = new int[10];

// Write the Report Header to the console
Console.WriteLine("Student\t\tGrade\n");

foreach (string name in studentNames)
{
    string currentStudent = name;

    if (currentStudent == "Sophia")
        studentScores = sophiaScores;

    else if (currentStudent == "Andrew")
        studentScores = andrewScores;

    else if (currentStudent == "Emma")
        studentScores = emmaScores;

    else if (currentStudent == "Logan")
        studentScores = loganScores;

    // initialize/reset the sum of scored assignments
    int sumAssignmentScores = 0;

    // initialize/reset the calculated average of exam + extra credit scores
    decimal currentStudentGrade = 0;

    foreach (int score in studentScores)
    {
        // add the exam score to the sum
        sumAssignmentScores += score;
    }

    currentStudentGrade = (decimal)(sumAssignmentScores) / currentAssignments;

    Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t?");
}