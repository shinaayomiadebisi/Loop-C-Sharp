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
  }
}