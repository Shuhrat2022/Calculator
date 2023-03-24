using System;
System.Console.Write("Enter you 1st number:");
int firstNumber = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Enter you 2nd number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter you operation: \" + \" \" - \" \" * \" \" / \" \" % \" ");
string operation = Console.ReadLine();

//  ternary operator 
string message = 
    firstNumber >= 0 
    ? "1st number is positive" 
    : "1st number is negative"; 
System.Console.WriteLine(message);
if(firstNumber > secondNumber)
{
    System.Console.WriteLine("1st number is greater than 2nd number");
}
else if(firstNumber == secondNumber)
{
    System.Console.WriteLine("1st number is equal to 2nd number");
}
else
{
    System.Console.WriteLine("1st number is less than 2nd number");
}

string messages = operation switch
{
    "+" => $"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}",
    "-" => $"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}",
    "*" => $"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}",
    "/" => $"{firstNumber} / {secondNumber} = {firstNumber / secondNumber}",
    "%" => $"{firstNumber} % {secondNumber} = {firstNumber % secondNumber}",
    _=>"Operation Not Found!"
};
System.Console.WriteLine(messages);

if(firstNumber > 0)
{
    int counter = 0;
    while(counter < firstNumber)
    {
        System.Console.Write(counter);
        counter++;

    }
}
// switch(operation)
// {
//     case "+":System.Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}");break;
//     case "-":System.Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}");break;
//     case "*":System.Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}");break;
//     case "/":System.Console.WriteLine($"{firstNumber} / {secondNumber} = {firstNumber / secondNumber}");break;
//     case "%":System.Console.WriteLine($"{firstNumber} % {secondNumber} = {firstNumber % secondNumber}");break;
//     default: System.Console.WriteLine("Operation Not Found!");break;
// }