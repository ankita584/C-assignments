using System.ComponentModel.Design;
using System.Runtime.InteropServices.Marshalling;

student[] students = new student[]
{
    new student(){name = "ankita", gender = "female", dateofbirth =
    DateTime.Parse("01/01/1994")},
    new student(){name = "avinash", gender = "male", dateofbirth =
    DateTime.Parse("07/01/1996")},
    new student(){name = "bharati", gender = "female", dateofbirth=
    DateTime.Parse("05/12/2000")},
    new student (){name = "nihar", gender = "male", dateofbirth =
    DateTime.Parse("11/09/1990")}
};





institute seed = new institute(students) { name = "SEED INFOTECH"};
seed.details();


IsEligibleForDiscount del = criteria;

seed.StudentEligibleForDiscountInFees(del);

static bool criteria(student s)
{
    return s.name.StartsWith("a");
}




Console.Read();