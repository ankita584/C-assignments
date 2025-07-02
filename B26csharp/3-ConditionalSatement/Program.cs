//#region if else

//Console.WriteLine("please enter a number");

//int num = int.Parse(Console.ReadLine());

//if (num == 10)
//{
//    Console.WriteLine($"you entered:{num}=TEN");
//}
//else
//{
//    Console.WriteLine($"you entered:{num}=NOT TEN");
//    Console.WriteLine("please use only 10");
//}
//Console.Read();

//#endregion if else


#region if else if statement

//Console.WriteLine("please enter a number");
//int num = int.Parse(Console.ReadLine());

//if(num==10)
using System.ComponentModel.Design;

{
    //Console.WriteLine($"you entered : {num}=TEN");
}

//else if (num==20)
{
    //Console.WriteLine($"you entered : {num}=TWENTY");
}

//else if(num==30)
{
    //Console.WriteLine($"you entered : {num}=THIRTY");
}

//else
{
    //Console.WriteLine($"you entered : {num}= NOT 10 20 OR 30");
}
//Console.Read();

#endregion if else if statement

#region ternary operator

//Console.WriteLine("please enter a number");
//int num = int.Parse(Console.ReadLine());

//string result = (num == 10) ? "TEN" : "NOT TEN";
//Console.WriteLine($"you entered : {num} = {result}");

//Console.Read();

#endregion ternary operator

#region switch statement

Console.WriteLine("please enter a number");
int num = int.Parse(Console.ReadLine());

switch(num)
{
    case 10:
        Console.WriteLine($"{num}:TEN");
        break;
    case 20:
        Console.WriteLine($"{num}:TWENTY");
        break;
    case 30:
        Console.WriteLine($"{num}: THIRTY");
        break;
    default:
        Console.WriteLine($"{num}: NOT 10 20 OR 30");
        break;

}
Console.Read();

#endregion switch statement

#region example 1

Console.WriteLine("please enter first number");
int first = int.parse(Console.ReadLine());

Console.ReadLine("please enter second number");
int second = int.Parse(Console.ReadLine());

if(first > second)
{
    Console.WriteLine($"{first} is bigger than {second}");
}
else if(first < second)
{
    Console.WriteLine($"{second} is bigger than {first} ");
}
else
{
    Console.WriteLine($"{first}${second}are equal");
}
Console.Read();

#endregion example 1

#region example 2

Console.WriteLine("please enter first number");
int first = int.Parse(Console.ReadLine());

Console.WriteLine("please enter second number");
int second = int.Parse(Console.ReadLine());

Console.WriteLine("please enter third number");
int third = int.Parse(Console.ReadLine());

if (first > second)
{
    if (first > third)
    {
        Console.WriteLine($"{first}is bigger than {second} & {third}");
    }
    else
    {
        Console.WriteLine($"{third}is bigger than {first} & {second}");
    }
}
else if (first < second)
{
    if (second > third)
    {
        Console.WriteLine($"{second}is bigger than {first}&{third}");

    }
}
else
{
    if (third > first)
    {
        Console.WriteLine($"{third}is bigger than {first}&{second}");
    }
    elseif(first > third)
    {
        Console.WriteLine($"{first}is bigger than {second}&{third}");
    }
    else
    {
        console.writeline($"{first},{second} & {third} numbers are equal");
    }
}
Console.Read();
#endregion example 2