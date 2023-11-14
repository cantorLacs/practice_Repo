//-------------------------
using System.Diagnostics.Metrics;

Console.WriteLine("---------\n 1 \n---------");
//-------------------------

//do
//{
//    Console.WriteLine("Enter a number (int or float)");
//    float aNum = Convert.ToInt32(Console.ReadLine());

//    Console.WriteLine("Enter a number (int or float)");
//    float bNum = Convert.ToInt32(Console.ReadLine());

//    Console.WriteLine("would you like to perform an arithmetic operation (write ‘1’ or ‘a’) or a relational operation (choose ‘2’ or ‘r’).");
//    char operatorType = Convert.ToChar(Console.ReadLine());

//    switch (operatorType)
//    {
//        case '1' or 'a':

//            Console.WriteLine("Enter an arithmetic operator (+, -, *, / or %))");
//            char aOperator = Convert.ToChar(Console.ReadLine());

//            switch (aOperator)
//            {
//                case '+':
//                    Console.WriteLine($"{aNum} {aOperator} {bNum} = " + (aNum + bNum));
//                    break;
//                case '-':
//                    Console.WriteLine($"{aNum} {aOperator} {bNum} = " + (aNum - bNum));
//                    break;
//                case '*':
//                    Console.WriteLine($"{aNum} {aOperator} {bNum} = " + (aNum * bNum));
//                    break;
//                case '/' or '%':
//                    Console.WriteLine(bNum == 0 ? "Divition by zero not allowed" : aOperator == '/' ? $"{aNum} {aOperator} {bNum} = {aNum / bNum}" : $"{aNum} {aOperator} {bNum} = {aNum % bNum}");
//                    break;

//            }
//            break;
//        case '2' or 'r':

//            Console.WriteLine("Enter a relational operator (<, <=, >=, >, =, !)");
//            char bOperator = Convert.ToChar(Console.ReadLine());

//            switch (bOperator)
//            {
//                case '<':
//                    Console.WriteLine($"{aNum} {bOperator} {bNum} = " + (aNum < bNum));
//                    break;
//                //case '<=':
//                //    Console.WriteLine($"{aNum} {bOperator} {bNum} = " + (aNum - bNum));
//                //    break;
//                //case '>=':
//                //    Console.WriteLine($"{aNum} {bOperator} {bNum} = " + (aNum * bNum));
//                //    break;
//                case '>':
//                    Console.WriteLine($"{aNum} {bOperator} {bNum} = " + (aNum > bNum));
//                    break;
//                case '=':
//                    Console.WriteLine($"{aNum} {bOperator} {bNum} = " + (aNum == bNum));
//                    break;
//                case '!':
//                    Console.WriteLine($"{aNum} {bOperator} {bNum} = " + (aNum != bNum));
//                    break;
//            }
//            break;
//    }
//    Console.WriteLine("Would you like to run the program again? (y/n)");


//} while (Convert.ToChar(Console.ReadLine()) == 'y');


//-------------------------
Console.WriteLine("---------\n 2 \n---------");
//------------------------- 

//float temp;
//float speed;
//bool isValidTemp;
//bool isValidSpeed;
//do
//{

//    do
//    {
//        Console.WriteLine("Enter an air temperature value between -50 and +5");
//        temp = Convert.ToSingle(Console.ReadLine());

//        isValidTemp = temp >= -50 && temp <= 5;

//        Console.WriteLine(!isValidTemp ? "Value out of range\nTry again" : "");

//    } while (!isValidTemp);
//    do
//    {
//        Console.WriteLine("Now, enter a wind speed value between 5 and 80 km/h\"");
//        speed = Convert.ToSingle(Console.ReadLine());

//        isValidSpeed = speed >= 5 && speed <= 80;

//        Console.WriteLine(!isValidSpeed ? "Value out of range\nTry again" : "");

//    } while (!isValidSpeed);

//    //if (temp <= 5 && temp >= 0 || temp <= 0 && temp >= -10 && speed <= 55 || temp >= -15 && speed < 10)
//    //{
//    //    Console.WriteLine("confortable");
//    //}
//    //else if (temp <= -25 || temp <= -15 && speed > 45 || temp <= -20 && speed > 15)
//    //{
//    //    Console.WriteLine("Dangerous");
//    //}
//    //else /*if (temp > -10 && temp <= -5 && speed > 55 || temp > -15 && temp <= -10 && speed > 10 || temp > -20 && temp <= -15 && speed < 40 || temp > -25 && temp <= -20 && speed < 10)
//    //*/{
//    //    Console.WriteLine("Risky");
//    //}

//    switch (temp, speed)
//    {
//        case ( <= -25, > 5):
//        case ( <= -20, > 15):
//        case ( <= -15, > 45):
//            Console.WriteLine("Dangerous");
//            break;
//        case ( >= 0, > 50):
//        case ( >= -5, < 55):
//        case ( >= -10, < 10):
//            Console.WriteLine("Confortable");
//            break;
//        default:
//            Console.WriteLine("Risky");
//            break;
//    }
//    Console.WriteLine("would you like to run the program again? (y/n)");

//} while (Convert.ToChar(Console.ReadLine()) == 'y');


//-------------------------
Console.WriteLine("---------\n 3 \n---------");
//------------------------- 

do
{

    int sum = 0;
    int numberOfGrades = 0;
    do
    {


        int grade;
        bool isValidGrade;

        do
        {
            Console.WriteLine("Enter a grade between 0 and 100");
            grade = Convert.ToInt32(Console.ReadLine());

            isValidGrade = grade >= 0 && grade <= 100;

            Console.WriteLine(!isValidGrade ? "Value out of range\nTry again" : "");

        } while (!isValidGrade);

        sum = sum + grade;
        numberOfGrades++;

        Console.WriteLine("Would you like to enter another grade? (y/n)");

    } while (Convert.ToChar(Console.ReadLine()).Equals('y'));

    float avg = sum / numberOfGrades;
    Console.WriteLine($"The average of the grades is {avg}");
    Console.WriteLine("would you like to enter grades for another average calculation?(y/n)");

} while (Convert.ToChar(Console.ReadLine()).Equals('y'));

char achar;
bool validLetter;

Console.WriteLine("------------------");

do
{
    Console.WriteLine("Enter a letter grade that falls between ‘A’ and ‘F’, except ‘E’");

    achar = char.ToUpper(Convert.ToChar(Console.ReadLine()));

    validLetter = achar >= 'A' && achar <= 'F' && achar != 'E';

    Console.WriteLine(validLetter? $"letter {achar} is valid": $"letter {achar} is NOT valid");


} while (!validLetter);



//const float PassInGrade = 60.0f;
//const short MyPin = 8888;
//short userPin;


//-------------------------
Console.WriteLine("---------\n 6 \n---------");
//------------------------- 

//do
//{
//    Console.WriteLine("Pleas enter a valid pin to unlock to phone");

//    userPin = Convert.ToInt16(Console.ReadLine());

//} while (MyPin != userPin);


//-------------------------
Console.WriteLine("---------\n 9 \n---------");
//------------------------- 

//while (true)
//{
//    console.write("************* welcome to myflix! *************\r\nwhat are you in the mood for?\r\n1" +
//    " – non-stop awesome action\r\n2 – superhero & sci-fi\r\n3 – romantic but lit-wise deep\r\n4 –" +
//    " fun & uplifting adventures\r\n5 – kids time\r\n6 – educational\r\n7 - your faves\r\n answer: ");
//    int answer = convert.toint32(console.readline());
//    switch (answer)
//    {
//        case 1:
//            console.writeline("loading action movie!\n\n");
//            break;
//        case 2:
//            console.writeline("loading superhero & sci-fi movie!\n\n");
//            break;
//        case 3:
//            console.writeline("loading romantic but lit-wise deep movie!\n\n");
//            break;
//        case 4:
//            console.writeline("loading fun & uplifting adventures movie!\n\n");
//            break;
//        case 5:
//            console.writeline("loading kids time movie!\n\n");
//            break;
//        case 6:
//            console.writeline("loading educational movie!\n\n");
//            break;
//        case 7:
//            console.writeline("loading your faves movie!\n\n");
//            break;
//        default:
//            console.writeline("what are you doing?? try again\n\n");
//            break;
//    }
//}




