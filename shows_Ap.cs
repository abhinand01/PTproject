using System;
using System.IO;
using Newtonsoft.Json;

abstract class Shows_Ap {
    private int flag = 0;
    public abstract void shows_Ap ();

    public void search_Ap_shows () {
        using (StreamReader r = new StreamReader ("amazon.json")) {
            string json = r.ReadToEnd ();
            dynamic array = JsonConvert.DeserializeObject (json);
            Console.WriteLine ("Enter the serie name");
            string name = Console.ReadLine ();
            foreach (var item in array.series) {
                string name2 = item.name;
                if (name == name2) {
                    Console.WriteLine ("Found.......!\n");
                    Console.WriteLine (item.name);
                    Console.WriteLine (item.genre);
                    flag = 1;
                }
            }
            if (flag == 0)
                Console.WriteLine ("Show is not available");
        }
    }
    private void findamazonshow (string selectgenre) {
        using (StreamReader r = new StreamReader ("amazon.json")) {
            string json = r.ReadToEnd ();
            dynamic array = JsonConvert.DeserializeObject (json);
            string gn1;
            string gn2;
            foreach (var item in array.series) {
                gn1 = item.genre;
                gn2 = item.genre2;
                if (selectgenre == gn1 || selectgenre == gn2) {
                    Console.WriteLine ("Serie name:" + item.name);
                    Console.WriteLine ("genre:" + item.genre + "," + item.genre2);
                    Console.WriteLine ("IMDB Rating:" + item.rating);
                    Console.WriteLine ("Story line:" + item.storyline + "\n\n");
                    flag = 1;
                }

            }
            if (flag == 0)
                Console.WriteLine ("sorry.......");
        }
    }
    private void findamazonshow (double a) {
        using (StreamReader r = new StreamReader ("amazon.json")) {
            string json = r.ReadToEnd ();
            dynamic array = JsonConvert.DeserializeObject (json);
            foreach (var item in array.series) {
                double imdb = item.rating;
                //double imdb=double.Parse(imdb1);
                if (imdb >= a) {
                    Console.WriteLine ("Serie name:" + item.name);
                    Console.WriteLine ("genre:" + item.genre + "," + item.genre1);
                    Console.WriteLine ("IMDB Rating:" + item.rating);
                    Console.WriteLine ("Story line:" + item.storyline + "\n\n");
                    flag = 1;
                }
            }
            if (flag == 0)
                Console.WriteLine ("sorry......");
        }

    }
    public void select_Ap_genre () {
        Console.WriteLine ("enter your genre");
        string gen = Console.ReadLine ();
        findamazonshow (gen);
        Console.WriteLine ("Minimum rating you need");
        double rate = Convert.ToDouble (Console.ReadLine ());
        findamazonshow (rate);
    }
}