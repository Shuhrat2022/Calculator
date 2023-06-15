Console.Write("Enter you 1st number:");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter you 2nd number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter you operation: \" + \" \" - \" \" * \" \" / \" \" % \" ");
string operation = Console.ReadLine();

//  ternary operator 
string message = 
    firstNumber >= 0 
    ? "1st number is positive" 
    : "1st number is negative"; 
Console.WriteLine(message);
if(firstNumber > secondNumber)
{
    Console.WriteLine("1st number is greater than 2nd number");
}
else if(firstNumber == secondNumber)
{
    Console.WriteLine("1st number is equal to 2nd number");
}
else
{
    Console.WriteLine("1st number is less than 2nd number");
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
Console.WriteLine(messages);

if(firstNumber > 0)
{
    int counter = 0;
    while(counter < firstNumber)
    {
        Console.Write("/"+counter);
        counter++;

    }
}
// switch(operation)
// {
//     case "+":Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}");break;
//     case "-":Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}");break;
//     case "*":Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}");break;
//     case "/":Console.WriteLine($"{firstNumber} / {secondNumber} = {firstNumber / secondNumber}");break;
//     case "%":Console.WriteLine($"{firstNumber} % {secondNumber} = {firstNumber % secondNumber}");break;
//     default:Console.WriteLine("Operation Not Found!");break;
// }