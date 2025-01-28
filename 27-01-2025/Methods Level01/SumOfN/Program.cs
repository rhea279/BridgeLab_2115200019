using System;
class SumOfN{
	static void Main(){
    	//Input from User
    	Console.Write("Enter the number :");
    	int n = Convert.ToInt32(Console.ReadLine());
    	if(n > 0) { // Check if it's a natural number
        	Sum(n);
    	} else {
        	Console.WriteLine("Please enter a natural number (greater than 0).");
    	}
	}
	//Find the sum of n natural numbers using For loop
	static void Sum(int n){
    	int sum = 0;
    	for(int i = n;i>=1;i--){
        	sum += i;
    	}
		Console.WriteLine($"Sum of {n} natural numbers is : {sum}");
	}
}

