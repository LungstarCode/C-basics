
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