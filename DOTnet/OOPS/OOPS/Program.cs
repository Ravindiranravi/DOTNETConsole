//using System.Runtime.CompilerServices;

//namespace OOPS
//{
//internal class Program
//{
//private static void Main(string[] args)
//{
//    Supra c = new Supra();
//    c.brand = "Supra";
//    c.series = "Toyota GR supra";
//    c.specialfeatures = "with a twin turbo engine";
//    Console.WriteLine(c.getDetails());
//}


//private static void Main(string[] args)
//{
//    Company c = new Company();
//    c.Name = "ChangePond Technologies";
//    c.addressline1 = "SIPCOT,Siruseri";
//    c.city = "Chennai";
//    c.state = "Tamil Nadu";
//    c.pincode = 600073;
//    c.email = "contact@cp.com";
//    c.mobile = 987654321;
//    c.getaddress();
//    c.getcontact();

//    Console.WriteLine('\n');

//    Employee e = new Employee();
//    e.Name = "Ravinidran";
//    e.addressline1 = "SIPCOT,Siruseri";
//    e.city = "Chennai";
//    e.state = "Tamil Nadu";
//    e.pincode = 600073;
//    e.email = "contact@cp.com";
//    e.mobile = 987654321;
//    e.getaddress();
//    e.getcontact();

//}

//private static void Main(string[] args)
//{
//    Shop s = new Shop();
//    s.ProductName = "katana";
//    s.ProductPrice = "Rs.120000";
//    s.ProductCategory = "S1 Grade";
//    s.OutletName = " Chinese Sword";
//    s.Outletcity = "Wano";
//    s.OutletLocation = "Oden Palace";
//    s.getProductDetials();
//    s.OutletDetials();
//}
//enum PaymentOptions
//{
//    Creditcard,Debitcard,Netbanking,Wallet

//}

//class Payment
//{
//    public string invoicename { get; set; }
//    public PaymentOptions options;
//}
//private static void Main(string[] args) 
//{

//    Payment p = new Payment(); 


//    p.invoicename = "BroadBandBill";//ordinary assignment
//    p.options = PaymentOptions.Debitcard;//enum assignment
//    Console.WriteLine(p.invoicename +" "+ "is paid by " + p.options);

//    p.invoicename = "AmazonShopping";//ordinary assignmet 
//    p.options = PaymentOptions.Wallet;// enum assignmentt
//    Console.WriteLine(p.invoicename + "is paid by" + p.options);
//}

//  }

//}

using System.Net.Http.Headers;

//enum PaymentOptions
//{
//    CreditCard, DebitCard, NetBanking, Wallet
//}
//class Payment
//{
//    public string invoicename { get; set; }
//    public PaymentOptions options;
//    public override string ToString()
//    {
//        System.Console.WriteLine(base.GetHashCode());
//        return "Class1.ToString";
//    }
//}
//class Program
//{
//    private static void Main(string[] args)
//    {
//        Payment p1, p2;

//        p1 = new Payment();
//        p2 = new Payment();

//        bool b = p1.Equals(p2);

//        Console.WriteLine((b));

//        int t1 = p1.GetHashCode();
//        Console.WriteLine(t1);

//        string c = t1.ToString();
//        Console.WriteLine(c);

//    }
//    //override the ToString() method, which is the virtual method in System.Object class
//    public override string ToString()
//    {
//        System.Console.WriteLine(base.GetHashCode());
//        return "ToString";
//    }


//    /*
//    Payment p = new Payment();
//    p.invoicename = "BroadBandBill";
//    p.options = PaymentOptions.CreditCard;

//    Console.WriteLine(p.invoicename + " is paid by " +p.options);
//    p.invoicename = "AmazonShopping";
//    p.options = PaymentOptions.Wallet;
//    Console.WriteLine(p.invoicename + " is paid by " + p.options);
//}*/


//}


    enum PaymentOptions
{
    CreditCard, DebitCard, NetBanking, Wallet
}
class Payment
{
    public string invoicename { get; set; }
    public PaymentOptions options;
    public static int noofpayments, creditcard, debitcard, netbanking;
    static Payment()
    {
        noofpayments = 0;
        creditcard = 0;
        netbanking = 0;
        debitcard = 0;
    }
    public Payment()
    {
        noofpayments += 1;
    }
    public void getPayementOptionWiseCount()
    {
        if (this.options == PaymentOptions.CreditCard)
        {
            creditcard += 1;
        }
        else if (this.options == PaymentOptions.DebitCard)
        {
            debitcard += 1;
        }
        else if (this.options == PaymentOptions.NetBanking)
        {
            netbanking += 1;
        }
    }
    //public override string ToString()
    //{
    //    System.Console.WriteLine(base.GetHashCode());
    //    return "Class1.ToString";
    //}

    
}
//class Program
//{
//private static void Main(string[] args)
//{
//    Payment p = new Payment();
//    p.invoicename = "BroadBandBill";
//    p.options = PaymentOptions.CreditCard;
//    p.getPayementOptionWiseCount();
//    Console.WriteLine(p.invoicename + " is paid by " + p.options);
//    Payment p1 = new Payment();
//    p1.invoicename = "AmazonShopping";
//    p1.options = PaymentOptions.DebitCard;
//    p1.getPayementOptionWiseCount();
//    Console.WriteLine(p1.invoicename + " is paid by " + p1.options);
//    Payment p2 = new Payment();
//    p2.invoicename = "AmazonShopping - 1";
//    p2.options = PaymentOptions.NetBanking;
//    p2.getPayementOptionWiseCount();
//    Console.WriteLine(p1.invoicename + " is paid by " + p2.options);
//    Console.WriteLine("No of Payment recieved: " + Payment.noofpayments);
//    Console.WriteLine("No of times Credit Card Used: " + Payment.creditcard);
//    Console.WriteLine("No of times Debit Card Used: " + Payment.debitcard);
//    Console.WriteLine("No of times Net Banking  Used: " + Payment.netbanking);
//}



//}

//class Program
//{
//    class Profile<T1, T2>
//    {
//        public T1 Gender;
//        public T2 isAdult;
//    }
//    private static void Main(string[] args)

//    {

//        Profile<string, bool> profile;
//        profile = new Profile<string, bool>();
//        profile.Gender = "Male";
//        profile.isAdult = true;
//        Console.WriteLine("Gender: " + profile.Gender);
//        Console.WriteLine("Is Adult: " + profile.isAdult);
//        Profile<int, int> profile1;
//        profile1 = new Profile<int, int>();
//        profile1.Gender = 0;
//        profile1.isAdult = 0;
//        string gender = profile1.Gender == 1 ? "Female" : "Male";
//        Console.WriteLine("Gender: " + gender);
//        string isadult = profile1.isAdult == 0 ? "True" : "False";
//        Console.WriteLine("isAdult: " + isadult);

//    }
//}
/////ARRAY******

class Program
{
    public static void Main(string[] args)
    {
        string[] weekdays = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
        Console.WriteLine(weekdays[1]);
        
        Console.WriteLine("\n");

        Console.WriteLine("Using For Loop");
        for (int i = 0; i < weekdays.Length; i++)
         {
             Console.WriteLine(weekdays[i]);
         }
        Console.WriteLine("\n");
        Console.WriteLine("Using ForEach ");
        foreach (string day in weekdays)
        {
            Console.WriteLine(day);
        }
        Console.WriteLine("\n");

        Array.Sort(weekdays);
        Console.WriteLine("\n");

        Console.WriteLine("Sorted in Ascending");
 
        foreach (string day in weekdays )
        {
            Console.WriteLine(day);
        }
        Console.WriteLine("\n");

        Array.Reverse(weekdays);
        Console.WriteLine("\n");

        Console.WriteLine("Sorted in Descending ");
 
        foreach (string day in weekdays)
        {
            Console.WriteLine(day);
        }
        Console.WriteLine("\n");

        int daypos = Array.IndexOf(weekdays, "Sun");
        Console.WriteLine("\n");

        Console.WriteLine("Sunday is " + (daypos + 1) + " day of week ");
        Console.WriteLine("\n");

        //Array.Clear(weekdays, 0, 2);
        //Console.WriteLine("\n");

        weekdays[0] = "Sunday";
        Console.WriteLine("\n");

        Array.Resize(ref weekdays, 7);
        Console.WriteLine("\n");

        weekdays[6] = "Some Special Day";
        Console.WriteLine("\n");

        string[] weekdays_copy = new string[7];
        Console.WriteLine("\n");

        weekdays.Append("independance day");
        Console.WriteLine("\n");

        weekdays.CopyTo(weekdays_copy, 0);
        Console.WriteLine("\n");

        foreach (string day in weekdays_copy)
        {
            Console.WriteLine(day);
        }
    }
}

