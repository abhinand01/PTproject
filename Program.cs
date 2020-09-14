using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using System.IO;


namespace OTTplatform
{
    class Program /*:Ipayment_Nf,Ipayment_Ap*/ {
        static void Main (string[] args) {

             using (StreamReader r = new StreamReader("series.json"))
    {
        string json = r.ReadToEnd();
        dynamic array=JsonConvert.DeserializeObject(json);
        foreach(var item in array.input)
        {
        List<string> temp = new List<string>();
        Console.WriteLine(item.name);}
    }
       /*    string str, choice, ch;
            int age;
            Console.WriteLine ("----WELCOME TO OTT PLATFORMS PAGE----");
            Console.WriteLine ("Enter your user-name");
            str = Console.ReadLine ();
            Console.WriteLine ("Enter your age");
            age = Convert.ToInt32 (Console.ReadLine ());

            Console.WriteLine ("Choose your choice of platform: \nNETFLIX(select \'1\') \nAMAZON(select \'2\')");
            int opt = Convert.ToInt32 (Console.ReadLine ());
            switch (opt) {
                case 1:
                    Netflix ott1 = new Netflix (str, age);
                    showList sh1 = new showList ();
                    Console.WriteLine ("user name-----> " + ott1.name);
                    Console.WriteLine ("user age-----> " + ott1.age);
                    Console.WriteLine ("choose login-page or sign-up page(IF U DON'T HAVE A ACCOUNT)");
                    choice = Console.ReadLine ();
                    if (choice == "login") {
                        ott1.login ();
                    } else if (choice == "sign-up") {
                        ott1.signup ();
                        ott1.plans ();
                        //ott1.payment_Nf();
                        ott1.paymentOptions ();
                        ott1.login ();

                    }
                    Console.WriteLine ("==============================");
                    sh1.shows_Nf ();
                    Console.WriteLine ("==============================");
                    Console.WriteLine ("if you want to: \nsearch any show (PRESS 1) \nfind genre(PRESS 2) \nExit (PRESS 3)");
                    ch = Console.ReadLine ();
                    if (ch == "1") {
                        sh1.search_Nf_shows ();
                    } else if (ch == "2") {
                        sh1.select_Nf_genre ();
                    } else {
                        break;
                    }
                    //ott1.Disp_screen(15, 60);

                    break;
                case 2:
                    AmazonPrime ott2 = new AmazonPrime (str, age);
                    showList sh2 = new showList ();
                    Console.WriteLine ("user name-----> " + ott2.name);
                    Console.WriteLine ("user age-----> " + ott2.age);
                    Console.WriteLine ("choose login-page or sign-up page(IF U DON'T HAVE A ACCOUNT)");
                    choice = Console.ReadLine ();
                    if (choice == "login") {
                        ott2.login ();
                    } else if (choice == "sign-up") {
                        ott2.signup ();
                        Console.WriteLine("\n");
                        ott2.plans ();
                        Console.WriteLine("\n");
                        ott2.paymentOptions ();
                        //ott2.payment_Ap();
                    }
                    Console.WriteLine("==============================");
                    sh2.shows_Ap ();
                    Console.WriteLine ("==============================");
                    Console.WriteLine("\n");
                    Console.WriteLine ("if you want to: \nsearch any show (PRESS 1) \nfind genre(PRESS 2) \nExit (PRESS 3)");
                    ch = Console.ReadLine ();
                    if (ch == "1") {
                        sh2.search_Ap_shows ();
                    } else if (ch == "2") {
                        sh2.select_Ap_genre ();
                    } else {
                        break;
                    }
                    //ott2.Disp_screen(10, 55);

                    break;

            }
            Console.WriteLine ("\n");
            Console.WriteLine ("if you are paying both press 1 else 0");
            int a = Convert.ToInt16 (Console.ReadLine ());
            if (a == 1) {
                Console.WriteLine ("Enter the price of both of your plans ");
                Console.WriteLine ("Amount Paid for Netflix");
                int net = Convert.ToInt16 (Console.ReadLine ());
                Console.WriteLine ("Amount Paid for Amazon Prime");
                int ama = Convert.ToInt16 (Console.ReadLine ());
                payment p1 = new payment (net);
                payment p2 = new payment (ama);
                payment p3 = new payment ();
                p3 = p1 + p2;
                p3.discount ();
            } else
                Console.WriteLine ("Take both subscriptions and get our Special offer");*/
         }

    }
}