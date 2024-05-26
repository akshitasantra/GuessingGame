bool playing = true;
Random rand = new Random();
while (playing) {
int triesCounter = 0;
int randomNum = rand.Next(1,101);
Console.WriteLine("Pick a random number between 1 and 100.");
int playerGuess = Convert.ToInt32(Console.ReadLine());
triesCounter++;
while (playerGuess != randomNum) {
if (playerGuess < randomNum) {
Console.WriteLine("Your guess was too low.");
}
else if (playerGuess > randomNum) {
Console.WriteLine("Your guess was too high.");
}
Console.WriteLine("Guess again!");
playerGuess = Convert.ToInt32(Console.ReadLine());
triesCounter++;
}
Console.WriteLine("You won!");
Console.WriteLine("You took " + triesCounter + " tries.");
Console.WriteLine("Do you want to play again? yes or no");
string playingAgain = Console.ReadLine();
if (string.Equals(playingAgain, "no", StringComparison.OrdinalIgnoreCase)){
playing = false;
}
}