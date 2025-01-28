using System;
class CheckNum{
	static void Main(string[] args){
		//Input integer from the user
		Console.ReadLine("Enter an integer :");
		int n = Convert.ToInt32(Console.ReadLine());
		Console.Write($"The number {n} is {CheckingN(n)}");
	}
	
	static int CheckingN(int n){
		//1 for positive number 
		if(n>0){
			return 1;
		}
		//0 if number is zero
		else if(n == 0){
			return 0;
		}
		//return -1 for negative number
		else{
			return -1;
		}
	}
}