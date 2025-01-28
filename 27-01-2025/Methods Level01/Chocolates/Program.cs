using System;
class DivideChoc{
	static void Main(string[] args){
    	//Input the number of Chocolates
    	Console.Write("Enter the number of Chocolates:");
    	int numberOfChocolates  = Int32.Parse(Console.ReadLine());
    	//Input the number of Children
    	Console.Write("Enter the number of Children:");
    	int numberOfChildren  = Int32.Parse(Console.ReadLine());
		//Display results
		int[] result= ChocPerChild(numberOfChocolates,numberOfChildren);
		Console.Write($"The number of chocolates each child gets is {result[0]} and the number of remaining chocolates is {result[1]}");
    	
    }
	///Compute the number of chocolates each child gets and the number of remaining chocolates
	static int[] ChocPerChild(int numberOfChocolates, int numberOfChildren){
		int[] result = new int[2];
		//The number of chocolates each child gets
		result[0]= numberOfChocolates/numberOfChildren;
		//The number of remaining chocolates
    	result[1] = numberOfChocolates%numberOfChildren;
    	//Display the result
    	return result;

	}
}