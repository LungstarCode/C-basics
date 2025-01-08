
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

string[] names = {"Lungile", "Adam", "Mpumie"}; // create and initialize the array with some values 

Console.WriteLine($"There are {names.Length} people in the list.");
Console.WriteLine($"The name of the programmer is {names[0]}");

