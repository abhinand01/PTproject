using System;
using System.Threading;
class payment {
    private int price, amount;
    public double dis;
    private int cvv;
    private string mmyy,cardno, upi, userid, password;
    private char[] cardnumber=new char[16];
    public payment () { }

    public payment (int n) {
        price = n;
    }
    public static payment operator + (payment c1, payment c2) {
        payment c3 = new payment ();
        c3.price = c1.price + c2.price;
        return c3;
    }
    public void discount () {
        dis = price;
        dis = dis * 0.09;
        if (price > 1000) {
            Console.WriteLine (value: $"Total amount paying for both plat form {price}");
            Console.WriteLine (value: $"Amount of {dis} will be credited to your account as our discount");
        } else {
            Console.WriteLine ("Sorry... Your not Availed for this offer");
        }
    }
    public void paymentchannel (char[] a, string my, int cv) {
        Console.WriteLine(value: $"Rs.{amount} has been requested to cardnumber *************{a[13]}{a[14]}{a[15]}");
        Console.WriteLine ("...........");
        Thread.Sleep (3000);
        Random otp = new Random ();
        int otp1 = otp.Next (1000, 9999);
        Console.WriteLine ("OTP  :" + otp1);
        Console.WriteLine ("enter the otp number sent to the registered mobile number");
        int otp2 = Convert.ToInt16 (Console.ReadLine ());
        if (otp1 == otp2) {
            Console.WriteLine ("Loading... Do not exit While the transaction...");
            Thread.Sleep (2000);
            Console.WriteLine ("transacting.......");
            Thread.Sleep (2000);
            Console.WriteLine ("Transaction  Successful");
        } else
            Console.WriteLine ("OTP miss Matching. Try Again");
    }

    public void paymentchannel (string pt, string upiid) {
        Console.WriteLine (value: $"Rs.{amount} has been requested from upi :{upiid} in {pt}");
        Console.WriteLine ("accept the payment");
        Thread.Sleep (2000);
        Console.WriteLine ("Transaction pending.....");
        Thread.Sleep (1500);
        Console.WriteLine ("transaction Successful");
    }
    public void paymentchannel (string userid, string password, string bank) {
        this.userid = userid;
        this.password = password;
        Console.WriteLine (value: $"Welcome to {bank} netbanking");

        Thread.Sleep (3000);
        Random otp = new Random ();
        int otp1 = otp.Next (1000, 9999);
        Console.WriteLine ("OTP  :" + otp1);
        Console.WriteLine ("enter the otp number sent to the registered mobile number");
        int otp2 = Convert.ToInt16 (Console.ReadLine ());
        if (otp1 == otp2) {
            Console.WriteLine ("Loading... Do not exit While the transaction...");
            Thread.Sleep (2000);
            Console.WriteLine ("transacting.......");
            Thread.Sleep (2000);
            Console.WriteLine ("Transaction  Successful");
        } else
            Console.WriteLine ("OTP miss Matching. Try Again");

        Console.WriteLine (value: $"Rs.{amount} debited form your account.if it is not you contact your respective branch");

    }
    public void paymentOptions () {
        Console.WriteLine ("enter your amount:");
        amount = Convert.ToInt16 (Console.ReadLine ());
        Console.WriteLine ("Enter your Payment method as 1-ATM card 2-UPI 3-Netbanking");
        int opt = Convert.ToInt16 (Console.ReadLine ());
        switch (opt) {
            case 1:
                Console.WriteLine ("enter your card number");
                //for(int i=0;i<12;i++)
                cardno = Console.ReadLine ();
                cardnumber=cardno.ToCharArray();
                Console.WriteLine ("Enter the expiry(mm/yy): ");
                mmyy = Console.ReadLine ();
                Console.WriteLine ("Enter the CVV: ");
                cvv = Convert.ToInt32 (Console.ReadLine ());
                paymentchannel (cardnumber, mmyy, cvv);
                break;
            case 2:
                Console.WriteLine ("enter your UPI payment platform");
                string pay = Console.ReadLine ();
                Console.WriteLine ("enter your UPI ID");
                upi = Console.ReadLine ();
                paymentchannel (pay, upi);
                break;
            case 3:
                Console.WriteLine ("Enter your Bank name");
                string bank = Console.ReadLine ();
                Console.WriteLine ("enter your userid");;
                string user = Console.ReadLine ();
                Console.WriteLine ("enter your password");
                string pwd = Console.ReadLine ();
                Console.WriteLine ("redirecting...........");
                Thread.Sleep (2000);
                paymentchannel (user, pwd, bank);
                break;
            default:
                Console.WriteLine ("Wrong option");
                break;

        }
    }

}