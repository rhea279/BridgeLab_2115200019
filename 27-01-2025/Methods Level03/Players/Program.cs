using System;
class Players{
	static void Main(string[] args){
		//Create an int array named heights of size 11 and get 3 digits random height in cms for each player in the range 150 cms to 250 cms
		int[] height = new int[11];
		Random random = new Random();
		for(int i =0 ; i< height.Length;i++){
			height[i] = random.Next(150, 251);
		}
		 Console.WriteLine($"\nTotal Sum of Heights: {Sum(height)} cm");
        Console.WriteLine($"Mean Height: {Mean(height):F2} cm");
        Console.WriteLine($"Shortest Height: {Shortest(height)} cm");
        Console.WriteLine($"Tallest Height: {Tallest(height)} cm");
	}
	//Method to Find the sum of all the elements present in the array
	static int Sum(int[] height){
		int sum = 0;
		for(int i = 0 ;i < height.Length; i++){
			sum += height[i];
		}
		return sum;
	}
	//Method to find the mean height of the players on the football team
	static int Mean(int[] height){
		int total= Sum(height);
		return total/height.Length;
	}
	//Method to find the shortest height of the players on the football team 
	static int Shortest(int[] height){
		int shortest = height[0];
		int shortestIndex= 0;
		for(int i = 0; i < height.Length; i++){
			if(height[i]<shortest){
				shortest = height[i];
				shortestIndex = i+1;
			}
		}
		return shortestIndex;
	}
	//Method to find the tallest height of the players on the football team
	static int Tallest(int[] height){
		int tallest = height[0];
		int tallestIndex= 0;
		for(int i = 0; i < height.Length; i++){
			if(height[i]>tallest){
				tallest = height[i];
				tallestIndex = i+1;
			}
		}
		return tallestIndex;
	}
}