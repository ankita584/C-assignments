// coffee shop program

Console.WriteLine("WELCOME TO COFFEE SHOP!!!");
int smallquantity = 0;
int mediumquantity = 0;
int largequantity = 0;

string choice = string.Empty;
do
{
    Console.WriteLine("what would you like to have?");
    Console.WriteLine($"1-SMALL 10RS 2-MEDIUM 20RS 3-LARGE 30RS");

    int size = int.Parse(Console.ReadLine());

    switch (size)
    {
        case 1:
            Console.WriteLine($"How much small coffee?");
            smallquantity += int.Parse(Console.ReadLine());
            Console.WriteLine($"you have ordered{smallquantity}small coffee");
            break;
        case 2:
            Console.WriteLine($"How much medium coffee?");
            mediumquantity += int.Parse(Console.ReadLine());
            Console.WriteLine($"you have ordered{mediumquantity}medium coffee");
            break;
        case 3:
            Console.WriteLine($"How much large coffee?");
            largequantity += int.Parse(Console.ReadLine());
            Console.WriteLine($"you ordered{largequantity}large coffee");
            break;
        default:
            Console.WriteLine($"invalid order");
            break;
    }
    Console.WriteLine("Do you want to continue?");
    choice = Console.ReadLine().ToUpper();

} while (choice == "Y" || choice == "YES");

int totalbill = 0;

if (smallquantity > 0 || mediumquantity > 0 || largequantity > 0)
{
    Console.WriteLine("***** BILL RECEIPT *****");

    if (smallquantity > 0)
    {
        Console.WriteLine($"SMALL COFFEE {smallquantity} * 10 = {smallquantity * 10}rs");
    }
    if (mediumquantity > 0)
    {
        Console.WriteLine($"MEDIUM COFFEE {mediumquantity} * 20 = {mediumquantity * 20}rs");
    }
    if (largequantity > 0)
    {
        Console.WriteLine($"LARGE COFFEE {largequantity} * 30 = {largequantity * 30}rs");
    }

     totalbill = smallquantity * 10 + mediumquantity * 20 + largequantity * 30;
     Console.WriteLine($"***** TOTAL BILL = {totalbill} rs *****");

      Console.WriteLine("***** THANK YOU.VISIT AGAIN !!! *****");
}
else
{
    Console.WriteLine($"Bhag yaha se");
}
Console.Read();


   

 

