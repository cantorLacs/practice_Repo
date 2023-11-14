

Console.WriteLine("-----\n#1. [warm-up]\n-----");

//float[] aArray = new float[10]/* { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }*/;
//int index;
////for (int i = 0; i < aArray.Length; i++)
////{
////    aArray[i] = aArray[i] * aArray[i];
////}

////the for loop bellow asign the values of the array
//for (int i = 0; i < aArray.Length; i++)
//{
//    aArray[i] = i + 1;
//}

//float sum = 0;

//foreach (float item in aArray)
//{

//    Console.WriteLine($"{item} x {item} = {item * item}");
//    sum = sum + item;
//}
//Console.WriteLine($"\nthe sum of all values in the array is {sum}");

//Console.WriteLine("Enter a number to check whether it is in the array ");
//Single.TryParse(Console.ReadLine(), out float target);

//index = Array.IndexOf(aArray, target);
//Console.WriteLine(index == -1 ? $"the value {target} is NOT in the array" : $"the value {target} is in the array in the index {index}");

Console.WriteLine("-----\n2. [final grades]\n-----");

//int studentNumber;
//float[] grades;


//Console.WriteLine("Give me the mumber of students");
//Int32.TryParse(Console.ReadLine(), out studentNumber);
//grades = new float[studentNumber];
//Console.WriteLine("enter the grades of the students one by one");



//for (int i = 0; i < grades.Length; i++)
//{
//    Single.TryParse(Console.ReadLine(), out grades[i]);
//}
//Console.WriteLine("---\narray values");
//foreach (float grade in grades)
//{
//    Console.Write(grade + " ");
//}

//Console.WriteLine("\n-------");

//Console.WriteLine("max grade = " + getMax());
//Console.WriteLine("min grade = " + getMin());
//Console.WriteLine("avg grade = " + getAvg());


////Methods definition
//float getMax()
//{
//    return (grades.Max());
//}
//float getMin()
//{
//    return grades.Min();
//}
//float getAvg()
//{
//    return grades.Average();
//}

Console.WriteLine("-----\n3. [reverse an array]\n-----");

string input;

input = Console.ReadLine();
int nInput = input.Length;


Console.WriteLine("first array");
for (int i = nInput -1; i >= 0; i--)
{
    Console.Write(input[i]);
}
Console.WriteLine();

char[] arrayB = new char[input.Length];
Console.WriteLine("second array");
for (int i = nInput -1, j = 0; i >= 0 && j < nInput; i--, j++)
{
    arrayB[j] = input[i];
}
foreach (char item in arrayB)
{
    Console.Write(item);
}
Console.WriteLine();

Console.WriteLine("-----\n\n-----");

//string myID;
//bool myIDIsValid;

////input validation
//do
//{
//    Console.WriteLine("Enter an integer to be organized");
//    myID = Console.ReadLine();
//    myIDIsValid = !Int32.TryParse(myID, out int y); // Variable "y" doesn't do anything but TryParse requires an out value
//    Console.Write(!myIDIsValid ? "Invalid entry\nTry again\n" : "");
//} while (!myIDIsValid);

//Console.WriteLine("------");

//int nID = myID.Length;
//int[] myIDArray = new int[nID];

//for (int i = 0; i < myID.Length; i++)
//{
//    myIDArray[i] = Convert.ToInt32(myID[i]) - 48;
//}

//int x;

//for (int i = 0; i < nID - 1; i++)
//{
//    for (int j = 0; j < nID - i - 1; j++)
//    {
//        if (myIDArray[j] > myIDArray[j + 1])
//        {
//            x = myIDArray[j];
//            myIDArray[j] = myIDArray[j + 1];
//            myIDArray[j + 1] = x;

//            //this print the values 
//            foreach (int item in myIDArray)
//            {
//                Console.Write(item);
//            }
//            Console.WriteLine("");
//        }

//    }
//}


Console.WriteLine("-----\n\n-----");



//int[] id = {2, 2, 3, 4, 2, 2, 8}; // replace these digits with your school ID 
//int n = id.Length; // let n be the size of the array
//int x;
//// algorithm A
//for (int i = 0; i < n - 1; i++)
//{
//    for (int j = 0; j < n - i - 1; j++)
//    {
//        if (id[j] > id[j + 1])
//        {
//            //x = id[j];
//            //id[j] = id[j + 1];
//            //id[j + 1] = x;
//            (id[j], id[j + 1]) = (id[j + 1], id[j]);
//            foreach (int item in id)
//            {
//                Console.Write(item);
//            }
//            Console.WriteLine("");
//        }
//    }
//}


//int aInt = 1;
//int bInt = 2;

//(aInt, bInt) = (bInt, aInt);
//Console.WriteLine($"aInt = {aInt}");
//Console.WriteLine($"bInt = {bInt}");



Console.WriteLine("\n-----------------\n");

//int[] A = { 7, 13, 3, 11, 8, -17, -40 };
//int minDiffA = Int32.MaxValue;
//int maxDiffA = 0;
//int diffA = 0;

//for (int j = 0; j < A.Length - 1; j++)
//{
//    diffA = Math.Abs(A[j] - A[j + 1]);

//    if (diffA < minDiffA)
//    {
//        //Console.WriteLine($"iteration {j} -> diff = " + diff);
//        minDiffA = diffA;
//        //Console.WriteLine($"iteration {j} -> minDiff = " + minDiff);
//    }
//    if (diffA > maxDiffA)
//    {
//        //Console.WriteLine($"iteration {j} -> diff = " + diff);
//        maxDiffA = diffA;
//        //Console.WriteLine($"iteration {j} -> maxDiff = " + maxDiff);
//    }

//}
//Console.WriteLine("");
//Console.WriteLine("At the end of the loop minDiff = " + minDiffA);
//Console.WriteLine("At the end of the loop maxDiff = " + maxDiffA);

Console.WriteLine("\n-----------\n");

//int[] B = { 7, 17, 13, 2, 3, 11, 40, 30, 27, 15 };
//int minDiffB = Int32.MaxValue;
//int maxDiffB = 0;
//int minIndex1 = 0;
//int minIndex2 = 0;
//int maxIndex1 = 0;
//int maxIndex2 = 0;
//int diffB = 0;

//for (int i = 0; i < B.Length - 1; i++)
//{
//    Console.WriteLine($"Outer Iteration {i + 1}");
//    for (int j = i + 1; j < B.Length; j++)
//    {
//        diffB = Math.Abs(B[i] - B[j]);

//        Console.WriteLine($"{B[i]} and {B[j]}");

//        if (diffB < minDiffB)
//        {
//            minDiffB = diffB;
//            minIndex1 = i;
//            minIndex2 = j;
//        }
//        if (diffB > maxDiffB)
//        {
//            maxDiffB = diffB;
//            maxIndex1 = i;
//            maxIndex2 = j;
//        }
//    }

//    Console.WriteLine();
//}
//Console.WriteLine("---");
//Console.WriteLine("At the end of the loop minDiff = " + minDiffB + $", between {B[minIndex1]} @ position {minIndex1} " +
//    $"and {B[minIndex2]} @ position {minIndex2}");
//Console.WriteLine("At the end of the loop maxDiff = " + maxDiffB + $", between {B[maxIndex1]} @ position {maxIndex1} " +
//    $"and {B[maxIndex2]} @ position {minIndex2}");

Console.WriteLine("\n-----------\n");

