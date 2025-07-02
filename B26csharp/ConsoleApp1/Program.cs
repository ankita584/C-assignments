int a = 10;
Console.WriteLine($"a:{a}");
int b = 2;

int add = a + b;
Console.WriteLine($"Addition :{add}"); //12

int sub = a - b;
Console.WriteLine($"Substraction :{sub}"); //8

int mul = a * b;
Console.WriteLine($"Multiplication :{mul}"); //20

int div = a / b;
Console.WriteLine($"Division :{div}"); //5

int mod = a % b;
Console.WriteLine($"Reminder :{mod}"); //0



b = 3;
mod = a % b;
Console.WriteLine($"Reminder :{mod}"); //1

Console.WriteLine($"a:{a}");

a++; //a = a+1;
Console.WriteLine($"a++:{a}"); //11

//console.writeline($"a:{a++}");//a++// post increment// 11
Console.WriteLine($"a:{++a}"); //++a// pre increment// 12
Console.WriteLine($"a:{a}");//12

a--; //a = a-1;
Console.WriteLine($"a--:{a}"); //11

//console.writeline($"a:{a--}");//pre decrement//10
Console.WriteLine($"a:{a--}"); //post decrement//11
Console.WriteLine($"a:{a}");//10



//a = 10

// a = a + 5;

a += 5;
Console.WriteLine($"a+5:{a}"); //15

a -= 10;
Console.WriteLine($"a:{a}"); //5

a *= 3;
Console.WriteLine($"a:{a}"); //15

a = a / 3;

a = 10;

bool b1 = a == 10;
Console.WriteLine($"a==10:{b1}");

b1 = a != 10;
Console.WriteLine($"a!=10:{b1}");


//and operator

b1 = (a == 10) && (b == 10);
Console.WriteLine($"({a}==10)&&({b}==10):{b1}"); //false

b1 = (a == 10) && (b != 10);
Console.WriteLine($"({a}==10)&&({b}!=10):{b1}"); //true

//or operator

b1 = (a == 10) || (b == 10);
Console.WriteLine($"({a}==10)||({b}==10):{b1}"); //true

b1 = (b == 10) || (a == 10);
Console.WriteLine($"({b}==10)||({a}==10):{b1}"); //false


//type conversion
//convert one type value into anathor type

short v1 = 10;
Console.WriteLine($"short v1 :{v1}");

int v2 = v1; //short=>int
Console.WriteLine($"int v2:{v2}");

float v3 = v2; //int => float
Console.WriteLine($"float v3 :{v3}");

//using type cast operator

v3 = 10.5f;
int v4 = (int)v3; //float=>int
Console.WriteLine($"int v4 :{v4}");

string v5 = "1000";
//int v6=v5; // string=>int
int v6 = Convert.ToInt32(v5); //converting string to int

Console.WriteLine($"int v6 :{v6}");

v5 = "true";
bool v7 = Convert.ToBoolean(v5); //string=>bool
Console.WriteLine($"bool v7 :{v7}");

//using parse().tryparse() methodes
v5 = "120";

int v8 = int.Parse(v5); //string+>int
Console.WriteLine($"int v8 :{v8}");

//need to try parse() method

string s = "fdasfdas";

//int i = convert.toint32(s);
//int i = int,parse(s);

int i;
bool b = int.TryParse(s, out i);

Console.WriteLine($"|s conversation success : {b}int i : {i}");

s = "500";
b = int.TryParse(s, out i);
Console.WriteLine($"|s conversation success : {b}int i : {i}");



    Console.ReadLine();

