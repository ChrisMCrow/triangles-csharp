using System;
using System.Collections.Generic;

class Triangle
{
  private int _sideOne;
  private int _sideTwo;
  private int _sideThree;

  public void SetSideOne(int newSide)
  {
    _sideOne = newSide;
  }
  public int GetSideOne()
  {
    return _sideOne;
  }

  public void SetSideTwo(int newSide)
  {
    _sideTwo = newSide;
  }
  public int GetSideTwo()
  {
    return _sideTwo;
  }

  public void SetSideThree(int newSide)
  {
    _sideThree = newSide;
  }
  public int GetSideThree()
  {
    return _sideThree;
  }

  public int StringToInt()
  {
    string side = Console.ReadLine();
    int number = int.Parse(side);
    return number;
  }

  private bool IsEquilateral()
  {
    int sideOne = GetSideOne();
    int sideTwo = GetSideTwo();
    int sideThree = GetSideThree();

    if (sideOne == sideTwo && sideTwo == sideThree)
    {
      return true;
    }
    else
    {
      return false;
    }
  }
  private bool IsIsosceles()
  {
    int sideOne = GetSideOne();
    int sideTwo = GetSideTwo();
    int sideThree = GetSideThree();

    if (sideOne == sideTwo || sideOne == sideThree || sideTwo == sideThree)
    {
      return true;
    }
    else
    {
      return false;
    }
  }
  private bool IsTriangle()
  {
    int sideOne = GetSideOne();
    int sideTwo = GetSideTwo();
    int sideThree = GetSideThree();

    if ((sideOne + sideTwo) < sideThree || (sideOne + sideThree) < sideTwo || (sideTwo + sideThree) < sideThree)
    {
      return false;
    }
    else
    {
      return true;
    }
  }
  public string TriangleType()
  {
    if (IsTriangle())
    {
      if (IsEquilateral())
      {
        return " an equilateral ";
      }
      else if (IsIsosceles())
      {
        return " an isosceles ";
      }
      else
      {
        return " a scalene ";
      }
    }
    else
    {
      return " not a ";
    }
  }
}

public class Program
{
  public static void Main()
  {
    Triangle newTriangle = new Triangle();

    Console.WriteLine("Please enter the first side of the triangle.");
    // int intSideOne = StringToInt();
    newTriangle.SetSideOne(newTriangle.StringToInt());

    Console.WriteLine("Please enter the second side of the triangle.");
    // int intSideTwo = StringToInt();
    newTriangle.SetSideTwo(newTriangle.StringToInt());

    Console.WriteLine("Please enter the third side of the triangle.");
    // int intSideThree = StringToInt();
    newTriangle.SetSideThree(newTriangle.StringToInt());

    string type = newTriangle.TriangleType();
    Console.WriteLine("This is" + type + "triangle.");
    Main();
  }
}
