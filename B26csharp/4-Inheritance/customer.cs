public class customer//Base class
{
    public int ticketAmount;

    public void showTimings() //methode
    {
        //method field
        Console.WriteLine("**all todays shows **");
    }

    public void GetTicketamount()
    {
        Console.WriteLine($"Ticket amount : {ticketAmount}");
    }

   
}
