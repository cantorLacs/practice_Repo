// See https://aka.ms/new-console-template for more information

/*
 * 1
a. the current temperature
b. a letter grade
c. your final AP average
d. the number of students in a class
e. your favorite colour
f. the temperature required for baking a banana cake
g. your middle initial
h. your 7-digit student ID
i. your 10-digit mobile number
j. PI
k. the name of your bank
l. a yes/no answer to a question 
*/

//-------------------------
Console.WriteLine("---------\n 1 \n---------");
//-------------------------

float currentTemperature;
float grade;
float finalAPAverage;
int students;
string favColour;
int temperature;
char midInitial;
long studentID;
long mobileNumber;
double PI;
string bankName;
bool answer;

currentTemperature = 17.5f; 
grade = 100;
finalAPAverage = 100;
students = 24;
favColour = "orange";
temperature = 180;
midInitial = 'A';
studentID = 1234567;
mobileNumber = 5141234567;
PI = Math.PI;
bankName = "Bank of Ooo";
answer = true;

Console.WriteLine("currentTemperature = {0}", currentTemperature);
Console.WriteLine("grade = {0}", grade);
Console.WriteLine("finalAPAverage = {0}", finalAPAverage);
Console.WriteLine("students = {0}", students);
Console.WriteLine("favColour = {0}", favColour);
Console.WriteLine("temperature = {0}", temperature);
Console.WriteLine("midInitial = {0}", midInitial);
Console.WriteLine("studentID = {0}", studentID);
Console.WriteLine("mobileNumber = {0}", mobileNumber);
Console.WriteLine("PI = {0}", PI);
Console.WriteLine("bankName = {0}", bankName);
Console.WriteLine("answer = {0}", answer);

/*
 * 2
i. integer, float
ii. float, integer
iii. float, double
iv. char, integer
v. char, float
vi. integer, char
vii. float, char
*/

//-------------------------
Console.WriteLine("---------\n 2 \n---------");
//-------------------------

int a1 = 100;
float b1 = 5.6f;
float c1 = 4.2f;
char d1 = '@';
char e1 = 'B';
int f1 = 200;
float g1 = 3.3f;


//-------------------------
Console.WriteLine("---------\n Explicit Casting (Cast)(cast do NOT round)\n---------");
//-------------------------

float a2 = (float)a1;
int b2 = (int)b1;
double c2 = (double)c1;
int d2 = (int)d1;
float e2 = (float)e1;
char f2 = (char)f1;
char g2 = (char)g1;

Console.WriteLine("a1 = {0}, a1 = {1}", a1, a2);
Console.WriteLine("b1 = {0}, b1 = {1}", b1, b2);
Console.WriteLine("c1 = {0}, c1 = {1}", c1, c2);
Console.WriteLine("d1 = {0}, d1 = {1}", d1, d2);
Console.WriteLine("e1 = {0}, e1 = {1}", e1, e2);
Console.WriteLine("f1 = {0}, f1 = {1}", f1, f2);
Console.WriteLine("g1 = {0}, g1 = {1}", g1, g2);

//-------------------------
Console.WriteLine("---------\n implisit convetsion (https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/language-specification/conversions#1023-implicit-numeric-conversions) \n---------");
//-------------------------
//-------------------------
Console.WriteLine("---------\n (Conversion) (conversion round) \n---------");
//-------------------------

float aa2 = Convert.ToSingle(a1);
int bb2 = Convert.ToInt16(b1);
double cc2 = Convert.ToDouble(c1);
int dd2 = Convert.ToInt32(d1);
//float ee2 = Convert.ToSingle(e1);
char ff2 = Convert.ToChar(f1);
//char gg2 = Convert.ToChar(g1);

Console.WriteLine("a1 = {0}, aa1 = {1}", a1, aa2);
Console.WriteLine("b1 = {0}, bb1 = {1}", b1, bb2);
Console.WriteLine("c1 = {0}, cc1 = {1}", c1, cc2);
Console.WriteLine("d1 = {0}, dd1 = {1}", d1, dd2);
Console.WriteLine("error");
Console.WriteLine("f1 = {0}, ff1 = {1}", f1, ff2);
Console.WriteLine("error");

int myAge1 = 42;
float myAge2 = (float)myAge1;

Console.WriteLine("\n\nint myAge1 = 42;\nfloat myAge2 = (float)myAge1;\n--");


if (myAge1 == myAge2)
{
    Console.WriteLine("myAge1 is iqual to myAge2");
}
else
{
    Console.WriteLine("myAge1 is different to myAge2");
}

/*
 * 3
*/
//-------------------------
Console.WriteLine("---------\n 3 \n---------");
//------------------------- 

Console.WriteLine(" Enter a float for variable aaa1 ");
float aaa1 =Convert.ToSingle(Console.ReadLine());
int aaa2 = (int)aaa1;
Console.WriteLine("aaa1 (float) = {0}, aaa2 (int) = {1}", aaa1, aaa2);

//-------------------------
Console.WriteLine("---------\n---------\n---------");
//-------------------------
Console.WriteLine(" Enter an int for variable bbb1 ");
int bbb1 = Convert.ToInt32(Console.ReadLine());
float bbb2 = (float)bbb1;
Console.WriteLine("bbb1 (int) = {0}, bbb2 (float) = {1}", bbb1, bbb2);

//-------------------------
Console.WriteLine("---------\n---------\n---------");
//-------------------------
Console.WriteLine(" Enter an int or a float for variable ccc1 ");
string ccc1 = Console.ReadLine();


if (int.TryParse(ccc1, out int ccc2Int))
{
    Console.WriteLine("{0} is an integer", ccc2Int);
}
else if (float.TryParse(ccc1, out float ccc2Float))
{
    Console.WriteLine("{0} is a float", ccc2Float);
}
else
{
    Console.WriteLine("That's not an int or a float");
}




