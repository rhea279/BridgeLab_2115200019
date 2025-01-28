using System;
public class StudentVoteChecker{
	//Define a method public boolean CanStudentVote(int age) which takes in age as a parameter and returns true or false
	public bool CanStudentVote(int age){
		//if a negative return is false cannot vot
		if(age<0){
			return false;
		}
		//For valid age check for age is 18 or above return true
		else if(age >= 18){
			return true;
		}
		else{
			return false;
		}
	}
	public static void Main(string[] args){
		//Define an array of 10 integer elements
		int[] students = new int[10];
		StudentVoteChecker voteChecker = new StudentVoteChecker();
		//Input age of 10 Students
		for(int i = 0; i < 10; i++){
			Console.WriteLine($"Enter Student {i+1} Age:");
			students[i] = Convert.ToInt32(Console.ReadLine());
			if(voteChecker.CanStudentVote(students[i])){
				Console.WriteLine($"Student {i+1} can vote.");
			}
			else{
				Console.WriteLine($"Student {i+1} cannot vote.");
			}
		}
	}
}