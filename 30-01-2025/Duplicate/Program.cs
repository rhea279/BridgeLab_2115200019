using System;
class Duplicate{
	static void Main(string[] args){
		Console.Write("Enter a string:");
		string input = Console.ReadLine();
		string result = "";
		foreach(char c in input){
			if(!result.Contains(c))
					result += c;
		}
		// Display the modified string
		Console.Write($"String after removing duplicates is : {result}");
	}

}