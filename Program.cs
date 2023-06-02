
using LeetCodeProblems._1342._Number_of_Steps_to_Reduce_a_Number_to_Zero;
using LeetCodeProblems._1672._Richest_Customer_Wealth;
using LeetCodeProblems._412._Fizz_Buzz;

//_1672._Richest_Customer_Wealth
var maximumWealthClass = new MaximumWealthClass();
var maximumWealthArray = new int[][] {
    new int[] {1, 2, 3},
    new int[] { 3, 2, 1 }
};
Console.WriteLine("1672._Richest_Customer_Wealth");
Console.WriteLine(maximumWealthClass.MaximumWealth(maximumWealthArray));


//LeetCodeProblems._412._Fizz_Buzz
Console.WriteLine("LeetCodeProblems._412._Fizz_Buzz");
var fizzBuzzClass = new FizzBuzzClass();
Console.WriteLine(fizzBuzzClass.FizzBuzz(1).All(x => true));


//_1342._Number_of_Steps_to_Reduce_a_Number_to_Zero
Console.WriteLine("_Number_of_Steps_to_Reduce_a_Number_to_Zero");
var numberOfStepsClass = new NumberOfStepsClass();
Console.WriteLine(numberOfStepsClass.NumberOfSteps(14));

