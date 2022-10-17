/*internal class Program
{
    private static void Main(string[] args)
    {
        int randomNumber = new Random().Next(10, 100);

        int firstDigit = randomNumber / 10;

        int secondDigit = randomNumber % 10;

        int max = firstDigit;

        if (secondDigit > max) max = secondDigit;

        Console.WriteLine($"Максимальная цифра в числе {randomNumber} - это {max}");
    }
}
  
  string test = "Hello, Aselya";

  System.Console.WriteLine(test[7]);
  

string number = Convert.ToString(new Random().Next(100, 1000));

 Console.WriteLine(number);
 Console.WriteLine(number[0] + "" + number[2]);

int firstNumber = Convert.ToInt32(Console.ReadLine());
int secondNumber = Convert.ToInt32(Console.ReadLine());
if (firstNumber % secondNumber == 0)
{
    Console.WriteLine(firstNumber + ", " + secondNumber + "-> кратно");
} 
 else   Console.WriteLine(firstNumber + ", " + secondNumber + "-> не кратно, остаток " + firstNumber % secondNumber);
 */

int Number = Convert.ToInt32(Console.ReadLine());
int a = 23;
int b = 7;
if (Number % a == 0 && Number % b == 0 )
{
    Console.WriteLine(Number + "-> да");
} 
 else   Console.WriteLine(Number + "-> нет");



