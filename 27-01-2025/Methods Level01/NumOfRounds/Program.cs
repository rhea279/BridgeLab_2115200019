using System;
class NumOfRounds{
	static void Main(string[] args){
    	//Input the sides of the triangle from user
    	// Prompt user to input the sides of the triangular park
        Console.WriteLine("Enter the length of the first side of the triangle (in meters):");
        double s1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the length of the second side of the triangle (in meters):");
        double s2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the length of the third side of the triangle (in meters):");
        double s3 = Convert.ToDouble(Console.ReadLine());
		Rounds(s1,s2,s3);
    	
	}
	static void Rounds(double s1, double s2, double s3){
		//Calculate the number of rounds
    	double perimeter = s1+s2+s3;
    	double rounds = 5000/perimeter;
   	 
    	Console.Write($"The total number of rounds the athlete will run is {rounds:F2} to complete 5 km");
   	 
	}
}