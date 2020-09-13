using System;
using System.Collections.Generic;
using System.Linq;

class showList : IShows_Nf, IShows_Ap {
    //List<string> nf_shows=new List<string>(5);
    int gen;
    string search_ap, search_nf;
    string[] nf_shows = { "**lucifer**", "**vampire diaries**", "**FRIENDS**", "**Stranger Things**", "**Breaking Bad**" };
    string[] ap_shows = { "**The Boys**", "**Mirazpur**", "**Big Bang Theory**", "**Bandish Bandits**", "**Comicstaan**" };
    public void shows_Nf () {
        Console.WriteLine ("----Shows in netflix----");
        for (int i = 0; i < 5; i++)
            Console.WriteLine (nf_shows[i]);
    }
    public void select_Nf_genre () {
        Console.WriteLine ("Select the genre you prefer: \n -->comedy(1) \n -->action(2) \n -->drama(3) \n -->fantasy(4)");
        Console.WriteLine ("YOUR OPTION: ");
        gen = Convert.ToInt32 (Console.ReadLine ());
        switch (gen) {
            case 1:
                Console.WriteLine (nf_shows[2]);
                break;
            case 2:
                Console.WriteLine (nf_shows[4]);
                break;
            case 3:
                Console.WriteLine (nf_shows[0] + "and" + nf_shows[1]);
                break;
            case 4:
                Console.WriteLine (nf_shows[3]);
                break;
            default:
                Console.WriteLine ("Enter the valid genre type");
                break;
        }
    }
    public void search_Nf_shows () {
        Console.WriteLine ("Enter the show that you are looking for:");
        search_nf = Console.ReadLine ();
        //int s_ap = Int32.Parse(search_ap);
        int flag = 0;
        for (int i = 0; i < 5; i++) {
            if (nf_shows[i] == search_nf) {
                flag = 1;
                break;
            }
        }

        if (flag == 1)
            Console.WriteLine ("The Show is available..Enjoy Watching....");
        else
            Console.WriteLine ("Sry the Show is not Available");

    }
    public void select_Ap_genre () {
        Console.WriteLine ("Select the genre you prefer: \n -->comedy(1) \n -->action(2) \n -->drama(3) \n -->fantasy(4)");
        Console.WriteLine ("YOUR OPTION: ");
        gen = Convert.ToInt32 (Console.ReadLine ());
        switch (gen) {
            case 1:
                Console.WriteLine (ap_shows[2] + "and" + ap_shows[4]);
                break;
            case 2:
                Console.WriteLine (ap_shows[1]);
                break;
            case 3:
                Console.WriteLine (ap_shows[0]);
                break;
            case 4:
                Console.WriteLine (nf_shows[3]);
                break;
            default:
                Console.WriteLine ("Enter the valid genre type");
                break;
        }
    }
    public void shows_Ap () {
        Console.WriteLine ("----Shows in Amazon Prime----");
        for (int i = 0; i < 5; i++)
            Console.WriteLine (ap_shows[i]);
    }
    public void search_Ap_shows () {
        int flag = 0;
        Console.WriteLine ("Enter the show that you are looking for:");
        search_ap = Console.ReadLine ();
        //int s_ap = Int32.Parse(search_ap);
        for (int i = 0; i < 5; i++) {
            if (ap_shows[i] == search_ap) {
                flag = 1;
                break;
            }

        }
        if (flag == 1)
            Console.WriteLine ("The Show is available..Enjoy Watching....");
        else
            Console.WriteLine ("Sry the Show is not Available");
    }
}