/* ************************************************************************************* */
/* Rosy Bertacchini
/* Final Project: ENCAPSULATION
/*
/* This program apply the concept of ENCAPSULATION in their classes
/* ************************************************************************************* */


using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        // Necessary Instances
        List<Customer> customers  = new List<Customer>{};
        List<Order> orders  = new List<Order>{};
        
        // create data to test program
        CreateSomeCustomers();
        CreateSomeOrders();
        
        Console.Clear();
        int i = 1;
        Console.WriteLine($"---------------------------------------------------------------------");
        foreach( Order o in orders){
            double shippingCost = 0;

            Console.WriteLine($"Order No. {i}");
            Console.WriteLine($"PAKICKING LIST:"); 
            Console.WriteLine("");
            Console.WriteLine($"{o.PackingList()}");   //*****  Get the list of products for the order   ******
            Console.WriteLine(""); 
            Console.WriteLine($"Sub-Total {o.SubTotalCostOfTheOrder()}");
            
            // ****** Charge the shipping cost - inside US or the rest of the world 
            shippingCost =  o.GetShippingCost(customers[o.GetCustomerID()]);

            Console.ForegroundColor = ConsoleColor.Blue; 
            Console.WriteLine($"Shipping cost: ${shippingCost}"); 
            Console.ResetColor();                  
            Console.WriteLine("");
            Console.WriteLine($"Total for this order  {o.SubTotalCostOfTheOrder() + shippingCost}");                   

            Console.WriteLine($"\n\n\n\tSHIPPING LABEL");
            Console.ForegroundColor = ConsoleColor.Blue; 
            Console.WriteLine($"{o.ShippingLabel(customers[o.GetCustomerID()])}");  //*****  Get the shipping list for the order   ******
            Console.ResetColor();
            i++;
            Console.WriteLine($"---------------------------------------------------------------------");
        }



        // ************************************     CREATE DATA  ( 2 orders )     ***********************************************
        void CreateSomeOrders(){
            List<Product> products_order1  = new List<Product>{};
            List<Product> products_order2  = new List<Product>{};
            
            //Order No 1
            Order o1 = new Order();
            Product p1 = new Product(1,"Italian Zucca",10.0,5);
            Product p2 = new Product(2,"Tiger Nuts",18.5,2);
            Product p3 = new Product(3,"Asparagus",8.6,3);


            products_order1.Add(p1);
            products_order1.Add(p2);
            products_order1.Add(p3);

            o1.SetCustomerID(1);
            o1.SetProducts(products_order1);
            orders.Add(o1);

           //Order No 2

            Order o2 = new Order();
            Product p4 = new Product(4,"Mâche nantaise",10.00,5);
            Product p5 = new Product(5,"Chinise Parsley",7.5,2);
            Product p6 = new Product(6,"Moussaka",5.0,3);
            Product p7 = new Product(7,"Autumn Pumpkin",4.5,15);

            products_order2.Add(p4);
            products_order2.Add(p5);
            products_order2.Add(p6);
            products_order2.Add(p7);            
            
            o2.SetCustomerID(4);
            o2.SetProducts(products_order2);
            orders.Add(o2);
        }


        void CreateSomeCustomers(){
            Address address1 = new Address("123 Main St", "Chula Vista", "CA", 12345, "US");
            Address address2 = new Address("456 Oak St", "Rigby", "ID", 67890, "US");
            Address address3 = new Address("789 Pine St", "Orem", "UT", 54321, "US");
            Address address4 = new Address("Blvd. Real de San Francisco", "Tijuana", "BC", 22236, "MEXICO");
            Address address5 = new Address("381-383 Avenue Louise", "Brussels", "", 1050, "BELGIUM");
    
            Customer customer1 = new Customer(1, "Chris Poulos", address1);
            Customer customer2 = new Customer(2, "Jane Smith", address2);
            Customer customer3 = new Customer(3, "Bob Johnson", address3);
            Customer customer4 = new Customer(4, "Rosy Bertacchini", address4);
            Customer customer5 = new Customer(5, "Elsa Rusemberger", address5);
        
            customers.Add(customer1);
            customers.Add(customer2);
            customers.Add(customer3);
            customers.Add(customer4);
            customers.Add(customer5);
        }
        // ************************************     CREATE DATA      ***********************************************




    } // Main
} // Program 