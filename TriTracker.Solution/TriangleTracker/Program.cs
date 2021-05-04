using System;

namespace TriangleTracker
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("Please enter a number");
      string sideOneString = Console.ReadLine();
      int sideOne = int.Parse(sideOneString);
      Console.WriteLine("Please enter another number");
      string sideTwoString = Console.ReadLine();
      int sideTwo = int.Parse(sideTwoString);
      Console.WriteLine("Please enter a final number");
      string sideThreeString = Console.ReadLine();
      int sideThree = int.Parse(sideThreeString);
      Triangle userTriangle = new Triangle(sideOne, sideTwo, sideThree);
      bool triangle = userTriangle.CheckIfTriangle();
      if (triangle)
      {
        if (userTriangle.CheckIfScalene())
        {
          Console.WriteLine("That is a scalene triangle");
        }
        else if (userTriangle.CheckIsosceles())
        {
          Console.WriteLine("That is an isosceles triangle");
        }
        else if (userTriangle.CheckAllSidesEqual())
        {
          Console.WriteLine("That is an equilateral triangle");
        }
      }
      else
      {
        Console.WriteLine("That is not a triangle");
      }

    }
  }
}
