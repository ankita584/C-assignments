///child class
 
public class silverCustomer : customer
{
    #region before inheritance
    //public int ticketAmount = 150;

    //public void showTimings() //methode
    //{
    //    //method field
    //    Console.WriteLine("**all todays shows **");
    //}

    //public void GetTicketamount()
    //{
    //    Console.WriteLine($"Ticket amount : {ticketAmount}");
    //}
    #endregion before inheritance

    public silverCustomer()
    {
        ticketAmount = 150;
    }

    public void printTicket()
    {
        Console.WriteLine("silver ticket printed");
    }
}

