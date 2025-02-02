using System;
class Guessinggame{
	static void Main(string[] args){
		Console.WriteLine("Think of a number between 1 and 100.");
		Console.WriteLine("Press any key when you're ready...");
		Console.ReadKey();
		
	}
	static int GenerateGuess(int lower, int upper){
		Random random = new Random();
		return random.Next(lower, upper + 1);
		
	}
}