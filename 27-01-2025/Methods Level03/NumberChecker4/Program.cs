using System;
class NumberChecker{
	static void Main(string[] args){
		Console.WriteLine("Enter a number:");
        int number = Convert.ToInt32(Console.ReadLine());
		IsPrime(number);
		IsNeon(number);
		IsSpy(number);
		IsAutomorphic(number);
		IsBuzz(number);
	}
	static void IsPrime(int n){
		int count = 0;
		for(int i = 2; i<n;i++){
			if(n % i == 0){
				count++;
			}
		}
		if(count == 0){
			Console.WriteLine($"{n} is a Prime Number.");
		}
		else{
			Console.WriteLine($"{n} is not a Prime Number.");
		}
	}
	static void IsNeon(int n){
		int sum = 0;
		int square = n * n;
		while(square != 0){
			sum += square % 10;
			square /= 10;
		}
		if(sum == n){
		Console.WriteLine($"{n} is a neon Number.");
		}
		else{
			Console.WriteLine($"{n} is not a neon Number.");
		}
	}
	static void IsSpy(int n){
		int sum = 0;
		int product = 1;
		int temp = n;
		while(temp!=0){
			int digit = temp % 10;
			sum += digit;
			product *= digit;
			temp /= 10;
		}
		if(sum == product){
			Console.WriteLine($"{n} is a spy Number.");
		}
		else{
			Console.WriteLine($"{n} is not a spy Number.");
		}
	}
	static void IsAutomorphic(int n)
{
    int square = n * n;
    string numStr = n.ToString();
    string squareStr = square.ToString();

    // Check if the square ends with the number
    if (squareStr.EndsWith(numStr))
    {
        Console.WriteLine($"{n} is an Automorphic Number.");
    }
    else
    {
        Console.WriteLine($"{n} is not an Automorphic Number.");
    }
}
	static void IsBuzz(int n)
{
    // Check divisibility by 7 or if it ends with 7
    if (n % 7 == 0 || n % 10 == 7)
    {
        Console.WriteLine($"{n} is a Buzz Number.");
    }
    else
    {
        Console.WriteLine($"{n} is not a Buzz Number.");
    }
}


}