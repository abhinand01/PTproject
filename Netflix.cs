using System;
using System.Threading;

class Netflix : payment {
    public string name;
    public int age;
    private string phn, mail_id, pass;
    //string username;
    //string password;

    public Netflix () { }

    public Netflix (string name, int age) {
        this.name = name;
        this.age = age;
    }
    public virtual void signup () {
        Console.WriteLine ("---\"Welcome to Sign-Up page\"---");
        Console.WriteLine (value: $"Hello : {name}");
        Console.WriteLine ("Enter your phone number");
        phn = Console.ReadLine ();
        // Thread.Sleep (3000);
        Random otp = new Random ();
        int otp1 = otp.Next (1000, 9999);

        Console.WriteLine ("OTP  :" + otp1);
        Console.WriteLine ("enter the otp number sent to the given number");
        int otp2 = Convert.ToInt16 (Console.ReadLine ());
        if (otp1 == otp2)
            Console.WriteLine ("registration Successful");
        else
            Console.WriteLine ("OTP miss Matching. Try Again");
    }
    public void login () {
        Console.WriteLine ("---\"Welcome to Login-Page\"---");
        Console.WriteLine ("Enter your mail-id");
        mail_id = Console.ReadLine ();
        //Console.ReadKey();
        Console.WriteLine ("Enter your Passsword");
        ConsoleKeyInfo key;
        do {
            key = Console.ReadKey (true);
            if (key.Key != ConsoleKey.Backspace) {
                pass += key.KeyChar;
                Console.Write ("*");
            } else {
                Console.Write ("\b");
            }
        } while (key.Key != ConsoleKey.Enter);
        Console.WriteLine ("\n");
    }

    public virtual void Disp_screen (int n, int m) {
        int i;
        for (i = 0; i <= n; i++) {
            Console.Write ("*");
        }
        Console.WriteLine ("\n");
        Console.WriteLine ("HOME PAGE");
        Console.WriteLine ("| vampire Diaries || Teen wolf || lock and key|");
        for (i = 0; i <= n; i++) {
            Console.Write ("*");
        }

    }
    public virtual void plans () {
        Console.WriteLine (".........Netflix  Plans..........");
        Console.WriteLine ("Premium -4 Screens -899/M");
        Console.WriteLine ("Standard -2 Screens -649/M");
        Console.WriteLine ("Basic -1 Screens -499/M");
        Console.WriteLine ("Mobile -1 Screens -199/M");
    }
    public void threadrun () {

        Thread t1 = new Thread (new ThreadStart (signup));
        Thread t2 = new Thread (login);
        //Thread t3=new Thread(plans);
        t1.Start ();
        t1.Join ();
        t2.Start ();
        t2.Join ();

    }

}