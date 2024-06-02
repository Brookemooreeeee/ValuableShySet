using System;

class Program {
  public static void Main (string[] args) {
    //declare constant base rate
    const double BASE_RATE = 200;

    //Prompt user for hours and miles and read input from console
    Console.Write("Please enter how many hours you would like to reserve: ");
    var hoursForHire = Console.ReadLine();

    Console.Write("Please enter the number of miles involved in your move: ");
    var miles = Console.ReadLine();

    //Declare variable to store a parsed double value. If parsing is successful, calculate the move cost. If not, display an error message.
    double hoursAsNumber;
    double milesAsNumber;
    if (double.TryParse(hoursForHire, out hoursAsNumber) && double.TryParse(miles, out milesAsNumber)) {
      Console.WriteLine("Your estimated total moving fee is: ${0}", BASE_RATE + (hoursAsNumber * 150) + (milesAsNumber * 2)); 
    }
    else {
    Console.WriteLine("Invalid input. Please enter numbers only.");
    }
  }
}