using System;
using System.Threading;
using System.Linq;
class AmazonPrime : Netflix {
    private string nam;
    private int ag;
    private string phn;

    public string a_name   // property
  {
    get { return nam; }
    set { nam = value; }
  }
   public int a_age  // property
  {
    get { return ag; }
    set { ag = value; }
  }
    public override void signup () {
        Console.WriteLine (value: $"Hello : {nam} ---\"Welcome to Amazon\"---   ");
        Console.WriteLine ("Enter your phone number");
        phn = Console.ReadLine ();
        Thread.Sleep (3000);
        Random otp = new Random ();
        int otp1 = otp.Next (1000, 9999);
        Console.WriteLine ("OTP  :" + otp1);
        Console.WriteLine ("enter the otp number sent to the given number");
        int otp2 = Convert.ToInt16 (Console.ReadLine ());
        if (otp1 == otp2)
            Console.WriteLine ("Registration Successful");
        else
            Console.WriteLine ("OTP miss Matching. Try Again");

    }
    public override void Disp_screen (int n, int m) {
        int i, j;
        for (i = 1; i <= n; i++) {
            for (j = 1; j <= m; j++) {
                if (i == 1 || i == n ||
                    j == 1 || j == m)
                    Console.Write ("*");
                else
                    Console.Write (" ");
            }
            Console.WriteLine ();
        }

    }
    public override void plans () {
        Console.WriteLine (".........Amazom Prime  Plans..........");
        Console.WriteLine ("Annual -3 Screens -999/Y");
        Console.WriteLine ("Monthly -3 Screens -129/M");
    }

}