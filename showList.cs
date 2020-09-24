using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

class showList : Shows_Ap, IShows_Nf {

    string gen;
    int flag = 0;
    public override void shows_Ap () {
        using (StreamReader r = new StreamReader ("amazon.json")) {
            string json = r.ReadToEnd ();
            dynamic array = JsonConvert.DeserializeObject (json);
            foreach (var item in array.series) {
                Console.WriteLine (item.name);
            }
        }
    }
    public void shows_Nf () {

        using (StreamReader r = new StreamReader ("netflix.json")) {
            string json = r.ReadToEnd ();
            dynamic array = JsonConvert.DeserializeObject (json);
            foreach (var item in array.series) {
                //List<string> temp = new List<string>();

                Console.WriteLine (item.name);
            }
        }
    }
    public void movies_Ap () {

        using (StreamReader r = new StreamReader ("amazon.json")) {
            string json = r.ReadToEnd ();
            dynamic array = JsonConvert.DeserializeObject (json);
            foreach (var item in array.movies) {
                Console.WriteLine (item.name);
            }
        }
    }
    public void movies_Nf () {

        using (StreamReader r = new StreamReader ("netflix.json")) {
            string json = r.ReadToEnd ();
            dynamic array = JsonConvert.DeserializeObject (json);
            foreach (var item in array.movies) {
                Console.WriteLine (item.name);
            }

        }
    }
    public void findnetflixshow (string selectgenre) {
        using (StreamReader r = new StreamReader ("netflix.json")) {
            string json = r.ReadToEnd ();
            dynamic array = JsonConvert.DeserializeObject (json);
            string gn1;
            string gn2;
            foreach (var item in array.series) {
                gn1 = item.genre;
                gn2 = item.genre1;
                if (selectgenre == gn1 || selectgenre == gn2) {
                    Console.WriteLine ("Series name:" + item.name);
                    Console.WriteLine ("genre:" + item.genre + "," + item.genre1);
                    Console.WriteLine ("IMDB Rating:" + item.Rating);
                    Console.WriteLine ("Story line:" + item.Storyline + "\n\n");
                    flag = 1;
                }

            }
            if (flag == 0)
                Console.WriteLine ("sorry.......");
        }
    }
    public void findnetflixshow (double a) {
        using (StreamReader r = new StreamReader ("netflix.json")) {
            string json = r.ReadToEnd ();
            dynamic array = JsonConvert.DeserializeObject (json);
            foreach (var item in array.series) {
                double imdb = item.Rating;
                //double imdb=double.Parse(imdb1);
                if (imdb >= a) {
                    Console.WriteLine ("Series name:" + item.name);
                    Console.WriteLine ("genre:" + item.genre + "," + item.genre1);
                    Console.WriteLine ("IMDB Rating:" + item.Rating);
                    Console.WriteLine ("Story line:" + item.Storyline + "\n\n");
                    flag = 1;
                }
            }
            if (flag == 0)
                Console.WriteLine ("sorry......");
        }

    }
    public void select_Nf_genre () {

        Console.WriteLine ("enter your genre");
        gen = Console.ReadLine ();
        findnetflixshow (gen);
        Console.WriteLine ("Minimum rating you need");
        double rate = Convert.ToDouble (Console.ReadLine ());
        findnetflixshow (rate);
    }
    public void findnetflixmovie (string selectgenre) {
        using (StreamReader r = new StreamReader ("netflix.json")) {
            string json = r.ReadToEnd ();
            dynamic array = JsonConvert.DeserializeObject (json);
            string gn1;
            string gn2;
            foreach (var item in array.movies) {
                gn1 = item.genre;
                gn2 = item.genre1;
                if (selectgenre == gn1 || selectgenre == gn2) {
                    Console.WriteLine ("Movie name:" + item.name);
                    Console.WriteLine ("genre:" + item.genre + "," + item.genre1);
                    Console.WriteLine ("IMDB Rating:" + item.Rating);
                    Console.WriteLine ("Story line:" + item.Storyline + "\n\n");
                    flag = 1;
                }

            }
            if (flag == 0)
                Console.WriteLine ("sorry.......");
        }
    }
    public void findnetflixmovie (double a) {
        using (StreamReader r = new StreamReader ("netflix.json")) {
            string json = r.ReadToEnd ();
            dynamic array = JsonConvert.DeserializeObject (json);
            foreach (var item in array.movies) {
                double imdb = item.Rating;
                //double imdb=double.Parse(imdb1);
                if (imdb >= a) {
                    Console.WriteLine ("Series name:" + item.name);
                    Console.WriteLine ("genre:" + item.genre + "," + item.genre1);
                    Console.WriteLine ("IMDB Rating:" + item.Rating);
                    Console.WriteLine ("Story line:" + item.Storyline + "\n\n");
                    flag = 1;
                }
            }
            if (flag == 0)
                Console.WriteLine ("sorry......");
        }

    }
    public void select_Nf_movie_genre () {

        Console.WriteLine ("Enter the genre you prefer -->");
        gen = Console.ReadLine ();
        findnetflixmovie (gen);
        Console.WriteLine ("The movies above the rating -->");
        double rate = Convert.ToDouble (Console.ReadLine ());
        findnetflixmovie (rate);
    }
    public void search_Nf_shows () {
        using (StreamReader r = new StreamReader ("netflix.json")) {
            string json = r.ReadToEnd ();
            dynamic array = JsonConvert.DeserializeObject (json);
            Console.WriteLine ("Enter the series name");
            string name = Console.ReadLine ();
            foreach (var item in array.series) {
                string name2 = item.name;
                if (name == name2) {
                    Console.WriteLine ("Found.......!\n");
                    Console.WriteLine (item.name);
                    Console.WriteLine (item.genre);
                    Console.WriteLine (item.rating);
                    flag = 1;
                }
            }
            if (flag == 0)
                Console.WriteLine ("Show is not available");
        }

    }
    public void search_Nf_movies () {
        using (StreamReader r = new StreamReader ("netflix.json")) {
            string json = r.ReadToEnd ();
            dynamic array = JsonConvert.DeserializeObject (json);
            Console.WriteLine ("Enter the movie name");
            string name = Console.ReadLine ();
            foreach (var item in array.movies) {
                string name2 = item.name;
                if (name == name2) {
                    Console.WriteLine ("Found.......!\n");
                    Console.WriteLine (item.name);
                    Console.WriteLine (item.genre);
                    Console.WriteLine (item.Rating);
                    Console.WriteLine (item.Storyline);
                    flag = 1;
                }
            }
            if (flag == 0)
                Console.WriteLine ("Show is not available");
        }
    }
}