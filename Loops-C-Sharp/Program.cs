internal class Program
{
  private static void Main(string[] args)
  {
    Console.WriteLine("------------------- Loops ----------------------");
    Console.WriteLine("----------------- While Loop -----------------");

    Console.WriteLine("Show all the numbers from 1 to 10");
    var number = 1;
    while (number <= 10)
    {
      Console.WriteLine(number);
      number++;//number+=1
    }

    Console.WriteLine("Show all the odd numbers from 1 to 10");
    number = 1;
    while (number <= 10)
    {
      Console.WriteLine(number);
      number += 2;
    }

    Console.WriteLine("----------------- do..while Loop -----------------");
    number = 1;
    do
    {
      Console.WriteLine(number);
      number++;
    } while (number <= 10);

    Console.WriteLine("-----------------------------------------");
    Console.WriteLine("---------------- for Loop ----------------");
    for (int i = 1; i <= 10; i++)
    {
      Console.WriteLine(i);
    }

    Console.WriteLine("Initialization omitted");
    number = 19;
    for (; number >= 10; number--)
    {
      Console.WriteLine(number);
    }

    Console.WriteLine("Odd numbers using for loop");
    for (int counter = 1; counter <= 10; counter += 2)
    {
      Console.WriteLine(counter);
    }

    Console.WriteLine("-----------------------------------------");
    Console.WriteLine("----------------foreach Loop----------------");
    var names = new string[] { "John", "David", "Sarah", "Gary" };
    foreach (string name in names)
    {
      Console.WriteLine(name);
    }

    for (int index = 0; index < names.Length; index++)
    {
      string name = names[index];
      Console.WriteLine(name);
    }

    Console.WriteLine("Show colors using foreach");
    var colors = new List<string>() { "Red", "Green", "Blue" };
    foreach (string color in colors)
    {
      Console.WriteLine(color);
    }

    Console.WriteLine("-----------------------------------------");
    Console.WriteLine("--------------Nested Loops--------------");
    var numbers = new int[,]
    {
      {1,5,8,7,3},
      {2,4,5,6,9},
      {12,16,82,20,45}
    };
    for(var row=0; row<numbers.GetLength(0); row++)
    {
      for (int column = 0; column < numbers.GetLength(1); column++)
      {
        Console.Write($"{numbers[row, column]}\t");
      }
      Console.WriteLine();
    }

    Console.WriteLine("--------------Multiplication Table--------------");
    for (int i = 1; i <= 10; i++)
    {
      for (int j = 1; j <= 10; j++)
      {
        Console.Write($"{i*j}\t");
      }
      Console.WriteLine();
    }

    Console.WriteLine("--------------Loop until i--------------");
    for (int i = 1; i <= 10; i++)
    {
      for (int j = 1; j <= i; j++)
      {
        Console.Write($"{i*j}\t");
      }
      Console.WriteLine();
    }

    Console.WriteLine("-----------------------------------------");
    Console.WriteLine("--------------break/continue--------------");

    for (int i = 0; i <= 10; i++)
    {
      if(i % 2 == 0)//if i is an even number
        continue;
        Console.WriteLine(i);
      
    }

    Console.WriteLine("---Loop from 1..10 and show only numbers from 1..5---");

    for (int i = 0; i <= 10; i++)
    {
      if(i  == 5)
        break;
        Console.WriteLine(i);
      
    }
  }
}