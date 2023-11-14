

//-------------------------
using System;
using System.Formats.Asn1;
using System.Threading.Channels;

Console.WriteLine("---------\n  \n---------");
//------------------------- 

//int counter = 1;
//do
//{
//    Console.WriteLine($"run {counter} times");
//    counter++;
//} while (counter <= 5);

//int j = 1;
//while (j <= 5)
//{
//    Console.WriteLine($"run {j} times");
//    j++;
//}

//for (int i = 1; i <= 5; i++)
//{
//    Console.WriteLine($"run {i} times");
//}


//-------------------------
Console.WriteLine("---------\n 1 \n---------");
//------------------------- 

//int i;
//int sum = 0;
//for (i = 1; i <= 10; i++/*, Console.WriteLine(i)*/)
//{
//    Console.WriteLine(i);
//    sum = sum + i;
//}
//Console.WriteLine($"The sum of the numbers is {sum}");

//-------------------------
Console.WriteLine("---------\n 2 \n---------");
//------------------------- 


//for (int i = 33; i <= 126; i++)
//{
//    Console.Write(Convert.ToChar(i) + " ");
//}


//-------------------------
Console.WriteLine("\n---------\n 3 \n---------");
//------------------------- 

//for (int i = 0, j = 0; i <= 6; i++, j++, Console.WriteLine($" ---> after running the body of the loop i = {i}"))
//{
//    Console.Write(i != 3 && i != 6 ? i : " ");
//    //Console.Write(i%3 != 0 || i == 0 ? i : " ");
//}

//-------------------------
Console.WriteLine("\n---------\n 4 \n---------");
//------------------------- 

//for (int i = 1500; i < 2700; i++)
//{
//    Console.Write(i % 5 == 0 && i % 7 == 0 ? i + "\n" : "");
//    //    if (i % 5 == 0 && i % 7 == 0)
//    //    {
//    //        Console.WriteLine(i);
//    //    }
//}

//-------------------------
Console.WriteLine("---------\n 5 \n---------");
//------------------------- 

//int aInt;
//bool aIntIsValid;

//do
//{
//    Console.WriteLine("Enter an integer");
//    aIntIsValid = Int32.TryParse(Console.ReadLine(), out aInt);
//    Console.Write(!aIntIsValid ? "That's not an integer \nTry again" : "");

//} while (!aIntIsValid);

//for (int i = 1; i <= 10; i++)
//{
//    int mult = aInt * i;
//    Console.WriteLine($"{i} * {aInt} = {mult}");
//}

//-------------------------
Console.WriteLine("---------\n 6 \n---------");
//------------------------- 

//int aInt;
//bool aIntIsValid;
//bool isPrime = true;

//do
//{
//    Console.WriteLine("Enter a positive integer");
//    aIntIsValid = Int32.TryParse(Console.ReadLine(), out aInt) && aInt > 0;
//    Console.Write(!aIntIsValid ? "That's not a positive integer \nTry again" : "");
//} while (!aIntIsValid);

//for (int i = 2; i < aInt; i++)
//{
//    //Console.Write(aInt % i == 0 ? $"The number {aInt} is a prime number" : "");   /// ask
//    if (aInt % i == 0)
//    {
//        isPrime = false;
//        break;
//    }
//}
//Console.WriteLine(isPrime ? $"{aInt} is a prime number" : $"{aInt} is NOT a prime number");

//-------------------------
Console.WriteLine("---------\n 7 \n---------");
//------------------------- 

//int baseNum;
//bool baseNumIsValid;
//int expNum;
//bool expNumIsValid;
//int result = 1;
//string output = "";

//do
//{
//    Console.Write("A raised to the power of B \nA = ");
//    baseNumIsValid = Int32.TryParse(Console.ReadLine(), out baseNum) && baseNum > 0;
//    Console.Write(!baseNumIsValid ? $"{baseNum} is NOT a valid number \nTry again" : "");
//    //if (!aIntIsValid)
//    //{
//    //    Console.WriteLine($"{aInt} is NOT a valid number \nTry again");
//    //}
//} while (!baseNumIsValid);
//do
//{

//    Console.Write("B = ");
//    expNumIsValid = Int32.TryParse(Console.ReadLine(), out expNum) && expNum > 0;
//    //Console.WriteLine(!bIntIsValid ? $"{bInt} is NOT a valid number \nTry again" : "");
//    if (!expNumIsValid)
//    {
//        Console.WriteLine("$\"{bInt} is NOT a valid number \\nTry again\"");
//    }

//} while (!expNumIsValid);

//for (int i = 1; i <= expNum; i++)
//{
//    result = result * baseNum;

//    output = output + $"{baseNum}"; // optional
//    if (i != expNum) output = output + $" * "; // optional
//}

//Console.WriteLine($"{baseNum} ^ {expNum} = {result}");

//output = output + $" = {result}"; // optional
//Console.WriteLine(output); // optional

//-------------------------
Console.WriteLine("---------\n 8 \n---------");
//------------------------- 

//int aInt;
//bool aIntIsValid;
//string output = "";
//int result = 1;

//do
//{
//    Console.WriteLine("Enter a positive integer");
//    aIntIsValid = Int32.TryParse(Console.ReadLine(), out aInt) && aInt > 0;
//    Console.WriteLine(!aIntIsValid ? "That's not a positive integer \nTry again" : "");
//} while (!aIntIsValid);


//for (int i = aInt; i >= 1; i--)
//{
//    result = result * i;
//    output = output + $"{i}";
//    if (i > 1)
//    {
//        output = output + " * ";
//    }

//}
//Console.WriteLine($"The factorial of {aInt} is {result}");

//output = output + $" = {result}";
//Console.WriteLine(output);

//-------------------------
Console.WriteLine("---------\n 9 \n---------");
//------------------------- 

//int aInt;
//bool aIntIsValid;
//bool result = false;
//int count = 0;

//do
//{
//    int intRandom = new Random().Next(1, 9);
//    do
//    {
//        Console.WriteLine("Enter a number between 1 and 9");
//        aIntIsValid = Int32.TryParse(Console.ReadLine(), out aInt) && aInt > 0;

//        //Console.WriteLine(intRandom);
//        Console.WriteLine(!aIntIsValid ? "That's not a number between 1 and 9" : "");

//    } while (!aIntIsValid);

//    count++;

//    Console.WriteLine(aInt != intRandom ? "Try again" : result = true);

//} while (!result);
//Console.WriteLine($"Well guessed! \nNumeber of guesses = {count}");

//-------------------------
Console.WriteLine("---------\n 10 \n---------");
//------------------------- 

int aInt;
bool aIntIsValid;
int evenSum = 0, oddSum = 0;
int evenCount = 0, oddCount = 0;
bool end, endIsValid;


Console.WriteLine("Enter integers one by one");
do
{
    do
    {
        Console.Write("Enter your number: ");
        aIntIsValid = Int32.TryParse(Console.ReadLine(), out aInt);
        Console.Write(!aIntIsValid ? "that's not a valid entry\nTry again." : "");
    } while (!aIntIsValid);

    if (aInt % 2 == 0) // even
    {
        evenSum = evenSum + aInt;
        evenCount++;
    }
    else if (aInt % 2 != 0) // odd
    {
        oddSum = oddSum + aInt;
        oddCount++;
    }

    do
    {
        Console.Write("do you want to enter another number? \n(y/n): ");
        endIsValid = char.TryParse(Console.ReadLine(), out char answer) && (answer == 'y' || answer == 'n');
        if (answer == 'y') end = true; else end = false;
        Console.Write(!endIsValid ? "that's not a valid entry\nTry again.\n" : "ok. ");


    } while (!endIsValid);
} while (end);

Console.WriteLine($"----\nThe number of odd numbers is {oddCount}");
Console.WriteLine($"The sum of odd numbers is {oddSum}");
Console.WriteLine($"The number of even numbers is {evenCount}");
Console.WriteLine($"The sum of even numbers is {evenSum}");





