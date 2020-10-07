using System;

class MainClass {
  public static void Main (string[] args) {
  MainClass.Hello("hello world"); //takes no input!

  Console.WriteLine("Give length of square");
  int length = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine("Give width of square");
  int width = Convert.ToInt32(Console.ReadLine());
  
  int area = Area(length, width); 
  // the two values above are being passed to the other function
  Console.WriteLine("Area = " + area);
  
  }

  public static void Hello(string msg) //takes no input, just words
  {
    Console.WriteLine(msg);
  }

  public static int Area(int len, int wid)
  // area is the name of the value 
  {
    int area = len * wid;
    return area;
  }
  // defining what function will do, reuseable code
}