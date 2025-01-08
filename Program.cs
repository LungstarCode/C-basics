
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