Console.WriteLine("Welcome to Basic Calculator App");
string choice = string.Empty;

do
{
    Console.WriteLine("Please enter numerator");
    int num = int.Parse(Console.ReadLine());

    Console.WriteLine("Please enter denominator");
    int den = int.Parse(Console.ReadLine());

    try
    {
        calculator c1 = new calculator();
        c1.Divide(num, den);
    }
    catch(Exception ex)
    {
     Console.WriteLine($"outer catch book : {ex.GetType().Name});
    }

    Console.WriteLine("Do you want to continue");
    choice = Console.ReadLine().ToUpper();

} while (choice == "Y" || choice == "YES");


Console.Read();