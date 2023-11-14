
////-------------------------
using System;

Console.WriteLine("---------\n 2 \n---------");
////------------------------- 

//Console.Write("Enter the first number: ");
//if (double.TryParse(Console.ReadLine(), out double num1))
//{
//}

//Console.Write("Enter the second number: ");

//if (double.TryParse(Console.ReadLine(), out double num2))
//{
//}



//double sum = num1 + num2;
//double difference = num1 - num2;
//double product = num1 * num2;
//double quotient = num1 / num2;
//double modulo = num1 % num2;


//Console.WriteLine("Sum: {0} + {1} = {2}", num1, num2, sum);
//Console.WriteLine("Difference: {0} - {1} = {2}", num1, num2, difference);
//Console.WriteLine("Product: {0} * {1} = {2}", num1, num2, product);
//Console.WriteLine("Quotient: {0} / {1} = {2}", num1, num2, quotient);
//Console.WriteLine("Modulo: {0} % {1} = {2}", num1, num2, modulo);

////-------------------------
Console.WriteLine("---------\n 3 \n---------");
////------------------------- 

//int years;
//int weeks;
//int months;

//bool isValid;
//int numX;

//do
//{
//    Console.Write("Enter a number of days: ");

//    numX = Convert.ToInt32((Console.ReadLine()));

//    isValid = numX > 0;
//    Console.WriteLine(!isValid ? "The number cannot be negative \n Try again" : "");

//} while (!isValid);
//years = (int)numX / 365;
//int remainingDaysInYear = (int)numX % 365;

//months = remainingDaysInYear / 30;
//int remainingDaysInMonths = remainingDaysInYear % 30;

//weeks = remainingDaysInMonths / 7;
//int days = remainingDaysInMonths % 7;


//Console.WriteLine(isValid ? $"{numX} Days = {years} Years, {months} months, {weeks} weeks and {days} days" : "the number of days cannot be negative");


////-------------------------
Console.WriteLine("---------\n 4 \n---------");
////------------------------- 


//int a = 3, b;
//a = b = 6 + 7;



//Console.WriteLine("int a = 3, b;\r\na = b = 6 + 7;\n");

//Console.WriteLine("a = " + a);
//Console.WriteLine("b = " + b);

//Console.WriteLine(" \n\n it's possible to assign the same value to multiple variables \n " +
//    "it's possible to declare and define in the same command");

////-------------------------
Console.WriteLine("---------\n final average \n---------");
////------------------------- 

//Console.Write("Enter your midTerm grade: ");
//float midTermGrade = float.Parse(Console.ReadLine());
//Console.Write("Enter your proyect grade: ");
//float proyectGrade = float.Parse(Console.ReadLine());
//Console.Write("Enter your finalExam grade: ");
//float finalExamGrade = Convert.ToSingle(Console.ReadLine());

//Console.WriteLine("-----");

//Console.WriteLine
//    (
//    "Your midterm grade is {0}\n" +
//    "your proyect grade is {1}\n" +
//    "your final exam grades is {2}", midTermGrade, proyectGrade, finalExamGrade
//    );

//float finalAPAverage = midTermGrade * 0.3f + proyectGrade * 0.3f + finalExamGrade * 0.4f;


//Console.WriteLine("-----");
//Console.WriteLine("you final AP Average is {0}", finalAPAverage);
//int finalAPAverageRounted = Convert.ToInt32(finalAPAverage);
//Console.WriteLine("you final AP Average rounted is {0}", finalAPAverageRounted);
//int finalAPAverageRounted1 = (int)Math.Round(finalAPAverage);
//Console.WriteLine("you final AP Average rounted is {0}", finalAPAverageRounted);


//-------------------------
Console.WriteLine("---------\n 5 \n---------");
//------------------------- 

//Console.WriteLine("Enter a character (a-z)");
//char aChar = Convert.ToChar(Console.ReadLine());

//bool isVowel = aChar == 'a' || aChar == 'e' || aChar == 'i' || aChar == 'o' || aChar == 'u';

//if (isVowel)
//{
//    Console.WriteLine("{0} is a vowel", aChar);
//}
//else
//{
//    Console.WriteLine("{0} is NOT a vowel", aChar);
//}

//-------------------------
Console.WriteLine("---------\n 6 \n---------");
//------------------------- 

//Console.Write("enter a 4-digit year: ");

//bool digit;
//int days;
//do
//{
//    digit = (int.TryParse(Console.ReadLine(), out days) && days >= 1000 && days <= 9999);
//    Console.WriteLine(!digit ? "That's not a 4 digit year \n Try again" : "");

//} while (!digit);

//if ((days % 4 == 0 && days % 100 != 0) || (days % 400 == 0))
//{
//    Console.WriteLine($"{days} is a leap year.");
//}
//else
//{
//    Console.WriteLine($"{days} is not a leap year.");
//}

    



//-------------------------
Console.WriteLine("---------\n 7 \n---------");
//------------------------- 


//int month;
//bool monthIsValid;
//int day;
//bool dayIsValid;
//int year;
//bool yearIsValid;

//do
//{
//    Console.Write("Enter the month (1-12): ");
//    monthIsValid = (Int32.TryParse(Console.ReadLine(), out month) && month >= 1 && month <= 12);
//    Console.WriteLine(!monthIsValid? "that's not a month \n Try again": "");

//} while (!monthIsValid);




//do
//{
//    Console.Write("Enter the day (1-31): ");
//    dayIsValid = (Int32.TryParse(Console.ReadLine(), out day) && day >= 1 && day <= 31);
//    Console.WriteLine(!dayIsValid ? "that's not a day \n Try again" : "");

//} while (!dayIsValid);



//do
//{
//    Console.Write("Enter the year (4 digits): ");
//    yearIsValid = (Int32.TryParse(Console.ReadLine(), out year) && year >= 1000 && year <= 9999);
//    Console.WriteLine(!yearIsValid ? "that's not a month \n Try again" : "");

//} while (!yearIsValid);

//int y0 = year - (14 - month) / 12;
//int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
//int m0 = month + 12 * ((14 - month) / 12) - 2;
//int d0 = (day + x + (31 * m0) / 12) % 7;

//Console.WriteLine($"{year}/{month}/{day}:");

//switch (d0)
//{
//    case 0:
//        Console.WriteLine("Sunday");
//        break;
//    case 1:
//        Console.WriteLine("Monday");
//        break;
//    case 2:
//        Console.WriteLine("Tuesday");
//        break;
//    case 3:
//        Console.WriteLine("Wednesday");
//        break;
//    case 4:
//        Console.WriteLine("Thursday");
//        break;
//    case 5:
//        Console.WriteLine("Friday");
//        break;
//    case 6:
//        Console.WriteLine("Saturday");
//        break;
//    default:
//        Console.WriteLine("What??");
//        break;
//}

//-------------------------
Console.WriteLine("---------\n 8 \n---------");
//------------------------- 


    //string season = null;
    //string season2 = null;

    //Console.Write("enter a month (1-12): ");
    //if (int.TryParse(Console.ReadLine(), out int month) && month >= 1 && month <= 12)
    //{
    //    Console.Write("enter a day (1-31): ");
    //    if (int.TryParse(Console.ReadLine(), out int day) && day >= 1 && day <= 31)
    //    {
    //        if ((month == 12 && day >= 21) || (month <= 2) || (month == 3 && day <= 20))
    //        {
    //            season = "winter";
    //        }
    //        else if ((month == 3 && day >= 21) || (month >= 4 && month <= 5) || (month == 6 && day <= 20))
    //        {
    //            season = "spring";
    //        }
    //        else if ((month == 6 && day >= 21) || (month >= 7 && month <= 8) || (month == 9 && day <= 20))
    //        {
    //            season = "summer";
    //        }
    //        else if ((month == 9 && day >= 21) || (month >= 10 && month <= 11) || (month == 12 && day <= 20))
    //        {
    //            season = "fall";
    //        }

    //        Console.WriteLine($"the season for {month}/{day} is: {season}");

    //        //        /////////////////////////////////////////////////////////////////
    //        //        //    /////precedence of operators
    //        //        //    //// && (and) has priority over || (or) then we can write each expression without the parentesis
    //        //        //    /// parentesis help with readability tho

    //        //        //    if (month == 12 && day >= 21 || month <= 2 || month == 3 && day <= 20)
    //        //        //    {
    //        //        //        season2 = "winter";
    //        //        //    }
    //        //        //    else if (month == 3 && day >= 21 || month >= 4 && month <= 5 || month == 6 && day <= 20)
    //        //        //    {
    //        //        //        season2 = "spring";
    //        //        //    }
    //        //        //    else if (month == 6 && day >= 2 || month >= 7 && month <= 8 || month == 9 && day <= 20)
    //        //        //    {
    //        //        //        season2 = "summer";
    //        //        //    }
    //        //        //    else if (month == 9 && day >= 21 || month >= 10 && month <= 11 || month == 12 && day <= 20)
    //        //        //    {
    //        //        //        season2 = "fall";
    //        //        //    }

    //        //        //    Console.WriteLine($"the season for {month}/{day} is: {season2}");
    //        //        /////////////////////////////////////////////////////////////////

    //    }
    //    else
    //{
    //    Console.WriteLine("Invalid day");
    //}
    //}
    //else
    //{
    //    Console.WriteLine("Invalid month");
    //}



//-------------------------
Console.WriteLine("---------\n 9 \n---------");
//------------------------- 


//Console.WriteLine("Enter a character (alphabet, digit, or special character)");

//if (char.TryParse(Console.ReadLine(), out char character))
//{
//    if (/*char.IsLetter(character)*/ 65 <= character && 90 >= character || 97 <= character && 122 >= character)
//    {
//        Console.WriteLine($"{character} is an alphabet.");
//    }
//    else if (/*char.IsDigit(character)*/ 48 <= character && 57 >= character)
//    {
//        Console.WriteLine($"{character} is a digit.");
//    }
//    else if (33 <= character && 47 >= character || 58 <= character && 64 >= character || 91 <= character && 96 >= character || 123 <= character && 255 >= character)
//    {
//        Console.WriteLine($"{character} is an special character.");
//    }
//}
//else
//{
//    Console.WriteLine("invalid entry");
//}

/////////////////////////////////////////////////////////////////

//Console.WriteLine("Enter a character (alphabet, digit, or special character)");

//char aChar = Convert.ToChar(Console.ReadLine());

//bool isDigit = 48 < aChar && 57 > aChar;
//bool isLetter = 65 < aChar && 90 > aChar
//    || 97 < aChar && 122 > aChar;
//bool isSpecialChar2 = !isDigit && !isLetter;

//Console.WriteLine(isSpecialChar);
//Console.WriteLine(isSpecialChar2);


//if (isLetter)
//{
//    Console.WriteLine($"{aChar} is an alphabet.");
//}
//else if (isDigit)
//{
//    Console.WriteLine($"{aChar} is a digit.");
//}
//else if (!isDigit || !isLetter)
//{
//    Console.WriteLine($"{aChar} is an special character.");
//}


