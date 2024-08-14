
//class Program

//{

//    private static void Main(string[] args)

//    {

//        List<string> products = new List<string>() { "Butter", "Bread", "Milk", "Cheese"};

//        //Console.WriteLine(products[0]);

//        //foreach (string product in products)

//        //{

//        //    Console.WriteLine(product);

//        //}

//        string flag = "Y";

//        string item = "";

//        while (flag == "Y" || flag == "y")

//        {

//            Console.Write("Enter the Product to Add : ");

//            item = Console.ReadLine();

//            products.Add(item);

//            Console.Write("Want to add more product press Y: ");

//            flag = Console.ReadLine();

//        }

//        Console.Write("Enter the Product to Add at the start : ");

//        item = Console.ReadLine();

//        products.Insert(0,item);

//        Console.WriteLine("Products List");

//        foreach (string product in products)

//        {

//            Console.WriteLine(product);

//        }

//        List <string> fruits = new List<string> { "Apple", "Kiwi", "Banana"};

//        Console.WriteLine("Do you want to clear the list before adding the fruit list");

//        flag = Console.ReadLine();

//        if(flag ==  "Y" || flag == "y")

//        {

//            products.Clear();

//        }

//        products.AddRange(fruits);

//        Console.WriteLine("Products List and Fruit List");

//        foreach (string product in products)

//        {

//            Console.WriteLine(product);

//        }

//        Console.Write("Which item to Remove: ");

//        item = Console.ReadLine() ;

//        products.Remove(item);

//        Console.WriteLine("List after removing the item: " + item);

//        foreach (string product in products)

//        {

//            Console.WriteLine(product);

//        }

//        Console.Write("Which position item to be removed: ");

//        int pos = Convert.ToInt32 (Console.ReadLine());

//        Console.WriteLine("List after removing the item at position : " + pos);

//        products.RemoveAt(pos);

//        foreach (string product in products)

//        {

//            Console.WriteLine(product);

//        }

//    }

//}
//class Program

//{

//    private static void Main(string[] args)

//    {

//        List<string> products = new List<string>() { "Butter", "Bread", "Milk", "Cheese"};

//        //Console.WriteLine(products[0]);

//        //foreach (string product in products)

//        //{

//        //    Console.WriteLine(product);

//        //}

//        string flag = "Y";

//        string item = "";

//        while (flag == "Y" || flag == "y")

//        {

//            Console.Write("Enter the Product to Add : ");

//            item = Console.ReadLine();

//            products.Add(item);

//            Console.Write("Want to add more product press Y: ");

//            flag = Console.ReadLine();

//        }

//        Console.Write("Enter the Product to Add at the start : ");

//        item = Console.ReadLine();

//        products.Insert(0,item);

//        Console.WriteLine("Products List");

//        foreach (string product in products)

//        {

//            Console.WriteLine(product);

//        }

//        List <string> fruits = new List<string> { "Apple", "Kiwi", "Banana"};

//        Console.WriteLine("Do you want to clear the list before adding the fruit list");

//        flag = Console.ReadLine();

//        if(flag ==  "Y" || flag == "y")

//        {

//            products.Clear();

//        }

//        products.AddRange(fruits);

//        Console.WriteLine("Products List and Fruit List");

//        foreach (string product in products)

//        {

//            Console.WriteLine(product);

//        }

//        Console.Write("Which item to Remove: ");

//        item = Console.ReadLine() ;

//        products.Remove(item);

//        Console.WriteLine("List after removing the item: " + item);

//        foreach (string product in products)

//        {

//            Console.WriteLine(product);

//        }

//        Console.Write("Which position item to be removed: ");

//        int pos = Convert.ToInt32 (Console.ReadLine());

//        Console.WriteLine("List after removing the item at position : " + pos);

//        products.RemoveAt(pos);

//        foreach (string product in products)

//        {

//            Console.WriteLine(product);

//        }

//    }

//}

using Microsoft.VisualBasic;

//class Progrm
//{


//    private static void Main(string[] args)

//    {

//        List<string> products = new List<string>() { "Butter ", "Bread ", "Milk ", "Cheese " };
//        List<int> price = new List<int>() { 300,150,80,100 };


//        foreach (string product in products)
//        {

//            Console.WriteLine(product);

//        }

//        string flag = "Y";

//        string item = "";


//        while (flag == "Y" || flag == "y")

//        {

//            Console.Write("Enter the Product to Add : ");

//            item = Console.ReadLine();

//            products.Add(item);

//            Console.Write("Want to add more product press Y: ");

//            flag = Console.ReadLine();

//        }

//        foreach (string product in products)
//        {

//            Console.WriteLine(product);

//        }
//        while (true)
//        {
//            Console.WriteLine("What do you want to do next:");
//            Console.WriteLine("1. Update");
//            Console.WriteLine("2. Remove");
//            Console.WriteLine("3. View the List");
//            Console.WriteLine("4. Exit");

//            string options = Console.ReadLine();

//            if (options == "4")
//            {
//                Console.WriteLine("Exiting the application.");
//                break;
//            }

//            switch (options)
//            {
//                case "1":
//                    UpdateProduct(products);
//                    break;
//                case "2":
//                    RemoveProduct(products);
//                    break;
//                case "3":
//                    ShowList(products);
//                    break;
//                default:
//                    Console.WriteLine("Invalid Input.Please Select the Correct Option");
//                    break;
//            }
//        }



//        static void ShowList(List<string> products)
//        {
//            foreach (string product in products)
//            {

//               Console.WriteLine(product);

//             }
//        }

//        static void UpdateProduct(List<string> products)
//        {
//            Console.Write("Enter the name of the product to be updated: ");
//            string oldItem = Console.ReadLine();


//            int index = products.IndexOf(oldItem);
//            if (products.Contains(oldItem))
//            {
//                Console.Write("Enter the new name for the product: ");
//                string newItem = Console.ReadLine();


//                products[index] = newItem;

//                Console.WriteLine("Product updated successfully ");

//                Console.WriteLine("Updated Products List:");
//                foreach (string product in products)
//                {
//                    Console.WriteLine(product);
//                }
//            }
//            else
//            {
//                Console.WriteLine("Product not found in the list,Please enter the correct value.");
//            }



//        }

//        static void RemoveProduct(List<string> products)
//        {
//            Console.Write("Which position item to be removed: ");

//            int pos = Convert.ToInt32(Console.ReadLine());

//            Console.WriteLine("list after removing the item at position : " + pos);

//            products.RemoveAt(pos);

//            foreach (string product in products)

//            {

//                Console.WriteLine(product);

//            }

//        }




//    }
//}
////Task******

//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Progrm
//{
//    private static void Main(string[] args)
//    {
//        List<string> products = new List<string>() { "Butter", "Bread", "Milk", "Cheese" };
//        List<int> prices = new List<int>() { 300, 150, 80, 100 };

//        ShowList(products, prices);

//        string flag = "Y";
//        while (flag == "Y" || flag == "y")
//        {
//            Console.Write("Enter the Product to Add: ");
//            string item = Console.ReadLine();
//            Console.Write("Enter the Price for the Product: ");
//            int price = int.Parse(Console.ReadLine());

//            if(!products.Contains(item) )
//            {

//                products.Add(item);
//                prices.Add(price);


//            }

//            Console.Write("Want to add more product? Press Y: ");
//            flag = Console.ReadLine();

//        }
//        Console.WriteLine("Products List:");
//        for (int i = 0; i < products.Count; i++)
//        {
//            Console.WriteLine(products[i] + " " + "Price:" + prices[i]);
//        }

//        while (true)
//        {
//            Console.WriteLine("What do you want to do next:");
//            Console.WriteLine("1. Update");
//            Console.WriteLine("2. Remove");
//            Console.WriteLine("3. View the List");
//            Console.WriteLine("4. Exit");

//            string options = Console.ReadLine();

//            if (options == "4")
//            {
//                Console.WriteLine("Exiting the application.");
//                break;
//            }

//            switch (options)
//            {
//                case "1":
//                    UpdateProduct(products, prices);
//                    break;
//                case "2":
//                    RemoveProduct(products, prices);
//                    break;
//                case "3":
//                    ShowList(products, prices);
//                    break;
//                default:
//                    Console.WriteLine("Invalid Input. Please Select the Correct Option");
//                    break;
//            }
//        }
//    }

//    static void ShowList(List<string> products, List<int> prices)
//    {
//        Console.WriteLine("Products List:");
//        for (int i = 0; i < products.Count; i++)
//        {
//            Console.WriteLine( products[i] +" " +"Price:" + prices[i]);
//        }
//    }

//    static void UpdateProduct(List<string> products, List<int> prices)
//    {
//        Console.Write("Enter the name of the product to be updated: ");
//        string oldItem = Console.ReadLine();

//        //foreach (string s in products) 
//        //{
//        //    Console.WriteLine(s);        
//        //}

//       // int index = products.IndexOf(oldItem);
//        int index = products.FindIndex(p => p.ToLower() == oldItem);
//        if (products.Contains(oldItem))
//        {
//            Console.Write("Enter the new name for the product: ");
//            string newItem = Console.ReadLine();
//            Console.Write("Enter the new price for the product: ");
//            int newPrice;
//            while (!int.TryParse(Console.ReadLine(), out newPrice))
//            {
//                Console.Write("Invalid price. Please enter a valid price: ");
//            }

//            products[index] = newItem;
//            prices[index] = newPrice;

//            Console.WriteLine("Product updated successfully.");
//        }
//        else
//        {
//            Console.WriteLine("Product not found in the list. Please enter the correct value.");
//        }

//        ShowList(products, prices);
//    }

//    static void RemoveProduct(List<string> products, List<int> prices)
//    {
//        Console.Write("Which position item to be removed (enter the index): ");
//        int pos;
//        while (!int.TryParse(Console.ReadLine(), out pos) || pos < 0 || pos >= products.Count)
//        {
//            Console.Write("Invalid position. Please enter a valid index: ");
//        }

//        products.RemoveAt(pos);
//        prices.RemoveAt(pos);

//        Console.WriteLine("List after removing the item at position " + pos + ":");
//        ShowList(products, prices);
//    }
//}




//using System;
//class Program
//{
//    private static void Main(string[] args)
//    {
//        List<int> ints = new List<int> { 10, 15, 32, 49, 25, 33, 22, 66, 89 };
//        List<int> evenlist = new List<int>();

//       evenlist = (from items in ints where (items % 2 == 0) select items).ToList();

//        foreach (int i in evenlist)
//            Console.WriteLine(i);


//    }


//}



//using System;
//using System.Collections.Generic;
//class Program
//{
//    private static void Main(string[] args)
//    {
//        List<string> products = new List<string>() { "Butter", "Bread", "Milk", "Cheese" };
//        foreach(string i in products)
//        {
//            Console.WriteLine(i);
//        }
//        List<string> userip = new List<string>();
//        Console.WriteLine("Enter the Product :");
//        string product = Console.ReadLine();

//        userip = (from pro in products where (pro.Equals(product,StringComparison.OrdinalIgnoreCase)) select pro).ToList();

//        if(products.Contains(product, StringComparer.OrdinalIgnoreCase))
//        {
//            foreach (string i in userip)
//            {
//                Console.WriteLine(i + " " + "Product is Available in Products");

//            }
//        }
//        else
//        {
//            Console.WriteLine("This product is Not Available");
//        }


//    }


//}

//namespace Collections;
//using System;

//class Program
//{
//    private static void Main(string[] args)
//    {
//        Product p1, p2, p3;
//        p1 = new Product(){ Id = 1,Name = "Shirts",Price = 250};
//        p2 = new Product(){Id = 1,Name = "T-Shirts",Price = 301};
//        p3 = new Product(){Id = 1,Name = "V-Neck T-Shirts",Price = 310};
//        List<Product> products = new List<Product>() { p1, p2, p3 };
//        List<Product> cartList = new List<Product>();

//        for (int i = 0; i < products.Count; i++)
//        {
//            Product items = products[i];
//            if (items.Price > 300)
//            {
//                cartList.Add(items);
//            }
//        }


//        for (int i = 0; i < cartList.Count; i++)
//        {
//            Product addeditems = cartList[i];
//            Console.WriteLine(addeditems.Name + " " + addeditems.Price);

//        }
//    }
//}

class Program
{
    private static void Main(string[] args)
    {
        Dictionary<int, string> empdetails;
        empdetails = new Dictionary<int, string>();
        empdetails.Add(100, "Parag");
        empdetails.Add(102, "Prachi");
        empdetails.Add(103, "Manas");

        string ename = empdetails[103];
        Console.WriteLine(ename);

        SortedList<string, int> Marks;
        Marks = new SortedList<string, int>();
        Marks.Add("Maths", 80);
        Marks.Add("Physics", 90);
        Marks.Add("English", 65);
        Marks.Add("Chemistry", 75);

        foreach (string key in Marks.Keys)
        {
            Console.WriteLine(Marks[key]);
        }
    }
}