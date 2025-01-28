using System;
class QuotientRemainder{
	static void Main(string[] args){
    	//Input the two numbers from the user
    	Console.WriteLine("Enter first number:");
    	int n1 = Int32.Parse(Console.ReadLine());
    	Console.WriteLine("Enter second number:");
    	int n2 = Int32.Parse(Console.ReadLine());
		//Display results
     	int[] result= Division(n1, n2);
    	Console.WriteLine($"The Quotient is {result[0]} and Remainder is {result[1]} of two numbers {n1} and {n2}");
	}
	//Calculate the quotient and remainder using division and modulus operator
	static int[] Division(int n1, int n2){
		int[] result = new int[2];
		//Use division operator (/) for quotient
    	result[0]= n1/n2;
		//Use modulus operator (%) for reminder
    	result[1] = n1%n2;
    	return result;
	}
}

