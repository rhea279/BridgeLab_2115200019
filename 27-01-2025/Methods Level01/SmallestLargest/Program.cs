using System;
class SmallestLargest{
	static void Main(string[] args){
		//Input 3 numbers from user
		Console.WriteLine("Enter first number :");
		int n1 = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter second numbe1	r :");
		int n2 = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter third number :");
		int n3 = Convert.ToInt32(Console.ReadLine());
		
		 // Get the largest and smallest numbers
        int[] result = CheckNumbers(n1, n2, n3);

        // Display the result
        Console.WriteLine($"Largest Number: {result[0]}");
        Console.WriteLine($"Smallest Number: {result[1]}");
	}
	public static int[] CheckNumbers(int n1, int n2, int n3){
		int[] result = new int[2];
		// Find the largest number
		if(n1 > n2 && n1 > n3){
			result[0] = n1;
		}
		else if(n2 > n1 && n2 > n3){
			result[0] = n2;
		}
		else if(n3 > n2 && n3 > n1){
			result[0] = n3;
		}
		// Find the smallest number
		if(n1 < n2 && n1 < n3){
			result[1] = n1;
		}
		else if(n2 < n1 && n2 < n3){
			result[1] = n2;
		}
		else if(n3 < n2 && n3 < n1){
			result[1] = n3;
		}
		return result;
	}
}